using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace GDI
{
    public partial class Form1 : Form
    {

       Graphics lienzo1 ;   
       
        // Pen

        Pen Rojo = new Pen(Color.Red, 1);

        Pen Azul = new Pen(Color.FromArgb(0, 0, 255), 3);

        Pen Verde = new Pen(Color.FromArgb(0, 255, 0), 4);

        

        public Form1()
        {
            InitializeComponent();

            //this.components = new System.ComponentModel.Container();
            //this.Size = new System.Drawing.Size(1000, 1000);
            //this.Text = "Display At Startup";
            //this.BackColor = Color.White;

           

        }

        public void form1_Paint(object sender, PaintEventArgs e)
        {
          lienzo1 = e.Graphics;

            


        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
            Graphics lienzo1 = this.CreateGraphics();
            //this.Show();

            // Pen

            Pen Rojo = new Pen(Color.Red, 1);

            Pen Azul = new Pen(Color.FromArgb(0, 0, 255), 3);

            Pen Verde = new Pen(Color.FromArgb(0, 255, 0), 4);

            



           

            






        }

        private void button1_Click(object sender, EventArgs e)
        {

            Graphics lienzo1 = this.CreateGraphics();
           
            // Lineas

            lienzo1.DrawLine(Verde, 20, 20, 30, 50);

            Point punto1 = new Point(400, 400);

            Point punto2 = new Point(410, 400);

            lienzo1.DrawLine(Azul, punto1, punto2);
        }

        private void button2_Click(object sender, EventArgs e)
        {

           Graphics lienzo1 = this.CreateGraphics();

            // Rectangunlo

            lienzo1.DrawRectangle(Verde, 40, 40, 80, 20);

            Rectangle Rec = new Rectangle(100, 100, 80, 20);

            lienzo1.DrawRectangle(Azul, Rec);


        }

        private void button3_Click(object sender, EventArgs e)
        {

            Graphics lienzo1 = this.CreateGraphics();


            //Elipse

            lienzo1.DrawEllipse(Rojo, 100, 100, 600, 200);

            Rectangle Rec = new Rectangle(250, 250, 500, 500);

            lienzo1.DrawEllipse(Azul, Rec);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics lienzo1 = this.CreateGraphics();


            //Arco

            lienzo1.DrawArc(Verde, 250, 250, 500, 500, 0, 180);

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Graphics lienzo1 = this.CreateGraphics();

            // Poligono

            Point[] Grupete =
            {
                new Point (100, 100),
                new Point (750, 250),
                new Point (254, 800),
                new Point (300, 450),
                new Point (800, 100)
            };
            lienzo1.DrawPolygon(Azul, Grupete);

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Clear
            Graphics lienzo1 = this.CreateGraphics();

            lienzo1.Clear(Color.White);
            

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Graphics lienzo1 = this.CreateGraphics();

            // Cardinal 

            Point[] Grupete =
            {
                new Point (100, 100),
                new Point (750, 250),
                new Point (254, 800),
                new Point (300, 450),
                new Point (800, 100)
            };
            lienzo1.DrawCurve(Azul, Grupete, 1);


        }

        private void button11_Click(object sender, EventArgs e)
        {
            Graphics lienzo1 = this.CreateGraphics();

            // Bezier 

            
            lienzo1.DrawBezier(Verde, 100,100, 100, 800, 100,500, 500,500);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Graphics lienzo1 = this.CreateGraphics();

            // Cerrada 

            Point[] Grupete =
            {
                new Point (100, 100),
                new Point (750, 250),
                new Point (254, 800),
                new Point (300, 450),
                new Point (800, 100)
            };
            lienzo1.DrawClosedCurve(Rojo, Grupete);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Path
            Graphics lienzo1 = this.CreateGraphics();
            GraphicsPath Path = new GraphicsPath();

            Rectangle Rec = new Rectangle(100, 250, 250, 100);
            Path.AddLine(100, 100, 100, 250);
            Path.AddRectangle(Rec);
            Path.AddBezier(250, 500, 250, 800, 250, 0, 400, 500);

            lienzo1.DrawPath(Azul, Path);



        }

        private void button8_Click(object sender, EventArgs e)
        {
            Graphics lienzo1 = this.CreateGraphics();
            SolidBrush Solido = new SolidBrush(Color.Coral);
            lienzo1.FillEllipse(Solido, 200, 200, 400, 300);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Graphics lienzo1 = this.CreateGraphics();
            HatchBrush Hatch = new HatchBrush(HatchStyle.BackwardDiagonal,Color.Blue,Color.Lime);
            lienzo1.FillEllipse(Hatch, 200, 200, 400, 300);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Gradiente
            Graphics lienzo1 = this.CreateGraphics();
            Rectangle Rec = new Rectangle(100, 250, 350, 600);
            LinearGradientBrush Grad = new LinearGradientBrush(Rec, Color.Lime, Color.Purple, LinearGradientMode.ForwardDiagonal);
            lienzo1.FillEllipse(Grad, 200, 200, 400, 300);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //mover

            Graphics lienzo1 = this.CreateGraphics();
            lienzo1.TranslateTransform(250, 250);
            lienzo1.DrawLine(Verde, 20, 20, 100, 300);

            Point punto1 = new Point(200, 250);

            Point punto2 = new Point(450, 400);

            lienzo1.DrawLine(Azul, punto1, punto2);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Rotar
            Graphics lienzo1 = this.CreateGraphics();
            lienzo1.TranslateTransform(150, 250);
            lienzo1.DrawRectangle(Azul, 0, 0, 50, 50);
            lienzo1.TranslateTransform(100, 0);
            lienzo1.RotateTransform(45);
            lienzo1.DrawRectangle(Azul, 0, 0, 50, 50);
            lienzo1.RotateTransform(-45);
            lienzo1.TranslateTransform(100, 0);
            lienzo1.RotateTransform(90);
            lienzo1.DrawRectangle(Azul, 0, 0, 50, 50);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            //Reset
            Graphics lienzo1 = this.CreateGraphics();
            lienzo1.ResetTransform();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //Escala
            Graphics lienzo1 = this.CreateGraphics();
            lienzo1.ScaleTransform(1.5F, 2F);
            lienzo1.DrawLine(Verde, 20, 20, 100, 300);

            Point punto1 = new Point(200, 250);

            Point punto2 = new Point(450, 400);

            lienzo1.DrawLine(Azul, punto1, punto2);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Graphics lienzo1 = this.CreateGraphics();
            Image dog = Image.FromFile("D:\\dog.png");
            TextureBrush Imagen = new TextureBrush(dog);
            lienzo1.TranslateTransform(100,100);
            Rectangle Rec = new Rectangle(0, 0, 300, 180);
            
            lienzo1.FillRectangle(Imagen, Rec);
            lienzo1.TranslateTransform(100, 0);
            lienzo1.FillEllipse(Imagen, 200, 200, 400, 300);
            lienzo1.DrawEllipse(Rojo, 200, 200, 400, 300);
            
        }
    }
}
