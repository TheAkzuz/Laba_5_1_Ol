using System.Collections;

namespace _5lab
{
    public partial class Form1 : Form
    {
        //это наш итог
        public double itog = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //создаём текстовую переменную и она принимает то, что писали 
            string str = textBox1.Text;
            //созаём стэк alg
            Stack alg = new Stack();
           
            //в этом сыкле мы по элементно суём в стек
            for (int i =0; i<str.Length;i++)
            {
                               alg.Push(str[i]);
                
            }

            

            if(alg.Count % 3 !=0) { label1.Text = "не все переменные имеют оператор"; return; }
            //это мы создаём строку, чтобы она приняла элмент иначе она прога ругается из-за char
            string l ="";
            //последний элемент из стека.
            l += alg.Pop();
            
            itog = Convert.ToDouble(l);

            //Цикл, который по идеи должен проводть операции 
            for (int i =0; i<alg.Count;i++)
            {
                //точно така логика с чаром
                l = "";

                l += alg.Pop();

                //второй элемент
                double a = Convert.ToDouble(l); 

                l = "";
                l += alg.Pop();
                //третий элемент, это знак
                string znak = Convert.ToString(l);

                if (znak[0] == '+')
                {
                    itog+= a;
                }
                if (znak[0] == '-')
                {
                    itog -= a;
                }
                if (znak[0] == '*')
                {
                    itog *= a;
                }
                if (znak[0] == '/')
                {
                    itog /= a;
                }



            }

            label1.Text = itog.ToString();
        }
    }
}