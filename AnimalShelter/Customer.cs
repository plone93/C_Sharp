using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    internal class Customer
    {
        public string firstName;
        public string lastName;
        private DateTime _Birthday;
        private bool _isQualified; //입양 가능 유무
        public string Address;
        public string Description; //설명

        private Cat _MyCat;
        public Cat MyCat
        {
            get { return _MyCat; }
        }

        public bool Adopt(Cat cat)
        {
            if (_isQualified)
            {
                _MyCat = cat;
                return true;
            }
            else 
            {
                return false;
            }
        }

        public Customer(string firstName, string lastName, DateTime Birthday)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this._Birthday = Birthday;

            this._isQualified = Age >= 18;
        }


        //속성
        public DateTime Birthday
        {
            get { return _Birthday; }
            set 
            {   
                _Birthday = value;
                _isQualified = Age >= 18;
            }
        }

        public int Age
        {
            get { return DateTime.Now.Year - _Birthday.Year; }
        }

        public bool GetIsQualified()
        {
            return _isQualified;
        }

        /*


        
        public void SetAge(int age)
        {
            _Age = age;
            _isQualified = age >= 18;
        }

        //읽기쓰기 속성, 인자의 이름은 value
        public int Age
        {
            get { return _Age; }
            set 
            {
                _Age = value;
                _isQualified = value >= 18;
            }
        }


        */

    }
}
