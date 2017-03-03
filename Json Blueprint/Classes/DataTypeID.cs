using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json_Blueprint
{
    class DataTypeID
    {
        private int id;

        private int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string dataType { get; set; }

        public DataTypeID(int id, string dataType)
        {
            this.id = id;
            this.dataType = dataType;
        }
    }
}
