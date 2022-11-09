namespace LeerArchivo2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string linea;
            try
            {
                StreamReader sr =
                    new StreamReader("C:\\Users\\Home\\Documents\\herramientas.txt");
                //Leer la primear línea
                linea = sr.ReadLine();

                //Continuar leyendo dentro de un ciclo
                while (linea != null)
                {
                    txtArchivo.Text += linea + System.Environment.NewLine;
                    //Leer la línea siguiente
                    linea = sr.ReadLine();
                }
                //Cerrar
                sr.Close();
               
            }catch(Exception ex)
            {
                MessageBox.Show("Error de lectura: " + ex.Message);
            }
        }
    }
}