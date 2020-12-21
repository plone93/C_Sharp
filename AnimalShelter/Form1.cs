using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class Form1 : Form
    {
        //멤버 필드
        private Customer customer;
        private List<Customer> cusList = new List<Customer>();//리스트
        
        int[] numberArr = new int[] { 1, 2, 3, 4, 5 }; //int형 배열,배열은 사용할 메모리를 등록하므로 먼저 사이즈지정 필요 {}는 초기 입력
        int[] numberArr2 = { 1, 2, 3, 4, 5 }; //int형 배열, 생략형
        Customer[] customersArr = new Customer[5]; //클래스 배열


        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            //Customer cus = new Customer(InputFirstName.Text, InputLastName.Text, new DateTime(2000,1,1));
            customer = new Customer(InputFirstName.Text, InputLastName.Text, DateTime.Parse(InputBirthday.Text));
            customer.Address = InputAddress.Text;
            customer.Description = InputNote.Text;

            cusList.Add(customer);
            
            CusFisrtName.Text = customer.firstName;
            CusLastName.Text = customer.lastName;
            CusAge.Text = customer.Age.ToString();
            //CusAge.Text = customer.Age.ToString();  속성
            CusAddress.Text = customer.Address;
            CusDescription.Text = customer.Description;
            CusQualified.Text = customer.GetIsQualified().ToString();

            //CustomerList.Items.Add(customer.firstName);

            CusListView.Rows.Add(customer.firstName, customer.Age, customer.GetIsQualified());
        }

        private void CusListView_CellClick(object sender, DataGridViewCellEventArgs e) //DataGridViewCellEventArgs으로 선택된 셀의 행번호가 반환됨
        {
            //클릭된 셀의 값을 가져옴
            String firstName = (string)CusListView.Rows[e.RowIndex].Cells[0].Value;
        }
        /*
private void CustomerList_Click(object sender, EventArgs e)
{
   //클릭된 아이템을 가져옴
   String firstName = CustomerList.SelectedItem.ToString();

   //DB에서 같은 이름이 있는지 검색
   foreach (var item in cusList)
   {
       if (item.firstName == firstName)
       {

       }
   }

}

*/


    }
}
