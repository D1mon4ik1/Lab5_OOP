namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "������ ����� �� ��� Java ��� �������� ���������� ������������ �����:";
            label2.Text = "���������:";
            label3.Text = " ";
            button1.Text = "���������";
            textBox1.ScrollBars = ScrollBars.Vertical;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            if (Validate(input))
            {
                label3.Text = "����� ������ ���������� ���������.";
            }
            else
            {
                label3.Text = "����� ������ ���������� �����������.";
            }
        }

        private static bool Validate(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in input)
            {
                if (ch == '(' || ch == '[' || ch == '{')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == ']' || ch == '}')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    char top = stack.Pop();
                    if ((ch == ')' && top != '(') || (ch == ']' && top != '[') || (ch == '}' && top != '{'))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }        
    }
}
