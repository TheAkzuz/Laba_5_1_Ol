using System.Collections;

namespace _5lab
{
    public partial class Form1 : Form
    {
        //��� ��� ����
        public double itog = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //������ ��������� ���������� � ��� ��������� ��, ��� ������ 
            string str = textBox1.Text;
            //����� ���� alg
            Stack alg = new Stack();
           
            //� ���� ����� �� �� ��������� ��� � ����
            for (int i =0; i<str.Length;i++)
            {
                               alg.Push(str[i]);
                
            }

            

            if(alg.Count % 3 !=0) { label1.Text = "�� ��� ���������� ����� ��������"; return; }
            //��� �� ������ ������, ����� ��� ������� ������ ����� ��� ����� �������� ��-�� char
            string l ="";
            //��������� ������� �� �����.
            l += alg.Pop();
            
            itog = Convert.ToDouble(l);

            //����, ������� �� ���� ������ �������� �������� 
            for (int i =0; i<alg.Count;i++)
            {
                //����� ���� ������ � �����
                l = "";

                l += alg.Pop();

                //������ �������
                double a = Convert.ToDouble(l); 

                l = "";
                l += alg.Pop();
                //������ �������, ��� ����
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