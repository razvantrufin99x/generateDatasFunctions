using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace generateDatasFunctions
{
    public partial class Form1 : Form
    {
        public Graphics g;
        public Pen pen0 = new Pen(Color.Black);
        
        public Form1()
        {
            InitializeComponent();
        }

        public double[] sinus = { 
0,
-0.00885130929040388,
0.0177019251054136,
-0.0265511540239668,
0.0353983027336607,
-0.044242678085071,
0.0530835871460582,
-0.0619203372560573,
0.0707522360803452,
-0.0795785916642835,
0.0883987124875315,
-0.0972119075182243,
0.106017486267114,
-0.114814758841666,
0.123603036000113,
-0.132381629205452,
0.141149850679391
};

        public double[] cosinus = {
                                   1,
-0.999960826394637,
0.999843308647691,
-0.99964745596635,
0.999373283695125,
-0.999020813314648,
0.998590072439991,
-0.9980810948185,
0.997493920327152,
-0.996828594969431,
0.996085170871722,
-0.995263706279229,
0.994364265551414,
-0.993386919156947,
0.992331743668192,
-0.991198821755207,
0.989988242179262

                                   };

        public double[] tangenta = { 
                                   0,
0.00885165604168446,
0.0177046992786858,
0.0265605177760394,
0.0354205013393769,
0.0442860423881244,
0.0531585368321877,
0.0620393849533013,
0.070929992292224,
0.0798317705429828,
0.0887461384553788,
0.0976745227469902,
0.106618359025928,
0.115579092725627,
0.124558180052983,
0.133557088951167,
0.142577300078512

                                   };

        public double[] cotangenta = {
                                          0,
                        112.973210356432,
56.4821793501951,
37.6498684412739,
28.2322373254582,
22.5804778678566,
18.8116539617489,
16.1187929369823,
14.0984084120594,
12.5263412448254,
11.2680959127342,
10.2380843220533,
9.37924771245837,
8.65208383642442,
8.02837677601451,
7.48743483294724,
7.0137392098836
                              };

        public double[] secanta = {
1,
-1.00003917513999,
1.00015671590834,
-1.00035266836478,
1.00062710932451,
-1.00098014643169,
1.00141191826248,
-1.00192259445797,
1.00251237588699,
-1.00318149483931,
1.00393021524942,
-1.0047588329514,
1.00566767596527,
-1.00665710481538,
1.00772751288139,
-1.0088793267825,
1.01011300679562

                                  };

        public double [] cosecanta = {
             0,                       
-112.977636097763,
56.4910310062368,
-37.6631463588112,
28.2499420247369,
-22.6026100426646,
18.838214479525,
-16.1497828389521,
14.1338289133988,
-12.5661937348512,
11.3123819551223,
-10.2868056550843,
9.43240624929056,
-8.70968166539494,
8.09041616096781,
-7.55391821359165,
7.08466920217582
                                     };
        public float coef = 5;
        public double unghi2rad = (180/Math.PI);

        public void draw(string s) {
            for (float i = 0; i < 360; i += (float)coef)
            {
                if (s == "sin")
                {
                    g.DrawLine(pen0, i, (float)Math.Sin(i / unghi2rad) * 50 + 250, (float)(i + coef), (float)Math.Sin((i + coef) / unghi2rad) * 50 + 250);
                }
                else if (s == "cos")
                {
                    g.DrawLine(pen0, i, (float)Math.Cos(i / unghi2rad) * 50 + 250, (float)(i + coef), (float)Math.Cos((i + coef) / unghi2rad) * 50 + 250);
                }
                else if (s == "tan")
                {
                    try
                    {
                        g.DrawLine(pen0, i, (float)Math.Tan(i / unghi2rad) * 50 + 250, (float)(i + coef), (float)Math.Tan((i + coef) / unghi2rad) * 50 + 250);
                    }
                    catch { }
                }
                else if (s == "ctg")
                {
                    try
                    {
                    g.DrawLine(pen0, i, (float)(1 / Math.Tan(i / unghi2rad)) * 50 + 250, (float)(i + coef), (float)(1 / Math.Tan((i + coef) / unghi2rad)) * 50 + 250);
                    }
                    catch { }
                }
                else if (s == "sec")
                {
                    try
                    {
                    g.DrawLine(pen0, i, (float)(1 / Math.Cos(i / unghi2rad)) * 50 + 250, (float)(i + coef), (float)(1 / Math.Cos((i + coef) / unghi2rad)) * 50 + 250);
                    }
                    catch { }
                }
                else if (s == "cosec")
                {
                     try
                    {
                    g.DrawLine(pen0, i, (float)(1 / Math.Sin(i / unghi2rad)) * 50 + 250, (float)(i + coef), (float)(1 / Math.Sin((i + coef) / unghi2rad)) * 50 + 250);
                    }
                     catch { }
                }
                else if (s == "radx")
                {
                    try
                    {
                        g.DrawLine(pen0, i, (float)(Math.Sqrt(i)) , (float)(i + coef), (float)(Math.Sqrt(i + coef)));
                    }
                    catch { }
                }
                else if (s == "logx")
                {
                    try
                    {
                        g.DrawLine(pen0, i, (float)(Math.Log(i)), (float)(i + coef), (float)(Math.Log(i + coef)));
                    }
                    catch { }
                }
                else if (s == "log10x")
                {
                    try
                    {
                        g.DrawLine(pen0, i, (float)(Math.Log10(i)), (float)(i + coef), (float)(Math.Log10(i + coef)));
                    }
                    catch { }
                }
                else if (s == "expxn")
                {
                    try
                    {
                        g.DrawLine(pen0, i, (float)(Math.Exp(i)), (float)(i + coef), (float)(Math.Exp(i + coef)));
                    }
                    catch { }
                }
                else if (s == "e")
                {
                    try
                    {
                        g.DrawLine(pen0, i, (float)(Math.E), (float)(i + coef), (float)(Math.E+ coef));
                    }
                    catch { }
                }
                else if (s == "puterexn")
                {
                    try
                    {
                        g.DrawLine(pen0, i, (float)(Math.Pow(2,i)), (float)(i + coef), (float)(Math.Pow(2,i+ coef)));
                    }
                    catch { }
                }
                else if (s == "punct")
                {
                    try
                    {
                        g.DrawEllipse(pen0, i, i+10, 2,2);
                    }
                    catch { }
                }
                else if (s == "linie")
                {
                    try
                    {
                        g.DrawLine(pen0, i, i + 10, i * -1, i + 10 * -1);
                    }
                    catch { }
                }
                else if (s == "parabola")
                {
                    try
                    {
                       
                        g.DrawLine(pen0,i,i*100,i,i*(-100));
                    }
                    catch { }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (float i = 0; i < 360; i += coef)
            {
                textBox1.Text += Math.Sin(i) + "\r\n";
                textBox2.Text += Math.Sin(i/unghi2rad) + "\r\n";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (float i = 0; i < 360; i += coef)
            {
                textBox1.Text += Math.Cos(i) + "\r\n";
                textBox2.Text += Math.Cos(i / unghi2rad) + "\r\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (float i = 0; i < 360; i += coef)
            {
                textBox1.Text += Math.Tan(i) + "\r\n";
                textBox2.Text += Math.Tan(i/unghi2rad) + "\r\n";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (float i = 0; i < 360; i += coef)
            {
                textBox1.Text += (1/Math.Tan(i)) + "\r\n";
                textBox2.Text += (1/Math.Tan(i / unghi2rad)) + "\r\n";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (float i = 0; i < 360; i += coef)
            {
                textBox1.Text += (1/Math.Cos(i)) + "\r\n";
                textBox2.Text += (1 / Math.Cos(i / unghi2rad)) + "\r\n";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (float i = 0; i < 360; i += coef)
            {
                textBox1.Text += (1/Math.Sin(i)) + "\r\n";
                textBox2.Text += (1 / Math.Sin(i / unghi2rad)) + "\r\n";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            draw("sin");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            draw("cos");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            draw("tan");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            draw("ctg");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            draw("sec");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            draw("cosec");
        }

        private void radicalxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            draw("radx");
        }

        private void logXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            draw("logx");
        }

        private void lnxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            draw("lnx");
        }

        private void log10xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            draw("log10x");
        }

        private void expnxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            draw("expxn");
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            draw("e");
        }

        private void puterexyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            draw("puterexn");
        }

        private void punctToolStripMenuItem_Click(object sender, EventArgs e)
        {
            draw("punct");
        }

        private void linieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            draw("linie");
        }

        private void parabolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            draw("parabola");
        }
    }
}
