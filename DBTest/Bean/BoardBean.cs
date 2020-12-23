using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTest.Bean
{
    public class BoardBean
    {
        public int BoardNum { get; set; }
        public string BoardId { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }


}
