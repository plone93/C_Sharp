using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Study1
{
    public partial class Calculator : Form
    {
        public int Result = 0;
        public bool isNewNum = true;

        public Calculator()
        {
            InitializeComponent();
        }
         
        private void HelloLabel_Click(object sender, EventArgs e)
        {


            //HelloLabel.Text = "Hello C#";

            int number1 = 1;
            int number2 = 2;

            int sum = number1 + number2;
            // HelloLabel.Text = sum.ToString();

            string operator1 = "+";
            bool isCorrect = true;




        }

        public int Sum(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }

        public int Minus(int number1, int number2)
        {
            int result = number1 - number2;
            return result;
        }


        /*

        private void Plus_Click(object sender, EventArgs e)
        {
            //int number1 = Convert.ToInt32(Sum1.Text);
            //int number2 = Convert.ToInt32(Sum2.Text);
            int number1 = 0;
            int number2 = 0;

            String.IsNullOrWhiteSpace(Sum1.Text);//스페이스 검사
            if (Sum1.Text == "" || Sum2.Text == "")//공백 검사
            {
                MessageBox.Show("숫자 입력");
                Sum1.Focus();
                return;
            }

            if (int.TryParse(Sum1.Text, out number1) == false || int.TryParse(Sum2.Text, out number2) == false)//정수로 변환, 실패시
            {
                MessageBox.Show("문자가 입력됨, 숫자 입력");
                Sum1.SelectAll();
                Sum1.Focus();
                return;
            }
            

            int sum = Sum(number1, number2);

            SumResult.Text = sum.ToString();
        }
        */
        public void SetNum(string num)
        {
            if (isNewNum)
            {
                NumScreen.Text = num;
                isNewNum = false;
            }
            else if (NumScreen.Text == "0")
            {
                NumScreen.Text = num;
            }
            else
            {
                NumScreen.Text = NumScreen.Text + num;
            }

        }

        private void Numbutton1_Click(object sender, EventArgs e)
        {
            SetNum("1");
            
        }

        private void Numbutton2_Click(object sender, EventArgs e)
        {
            SetNum("2");
        }

        private void Plusbutton_Click(object sender, EventArgs e)
        {
            int num = int.Parse(NumScreen.Text);//정수로 변환
            Result = Result + num;

            NumScreen.Text = Result.ToString();
            isNewNum = true;
        }
    }
}
