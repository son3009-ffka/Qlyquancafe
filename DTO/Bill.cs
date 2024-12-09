using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qlyquancafe.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? dateCheckin, DateTime? dateCheckout, int status, int discount = 0)
        {
            this.iD = id;
            this.dateCheckIn = dateCheckin;
            this.dateCheckOut = dateCheckout;
            this.Status = status;
            this.Discount = 0;
        }

        public Bill(DataRow row)
        {
            //this.iD = (int)row["id"];
            //this.dateCheckIn = (DateTime?)row["dateCheckin"];
            //var dateCheckOutTemp = row["dateCheckOut"];
            //if (dateCheckOutTemp != null) 
            //    this.dateCheckOut = (DateTime?)dateCheckOutTemp;
            //this.Status = (int)row["status"];



            // Kiểm tra nếu trường "id" không phải NULL và ép kiểu sang int
            this.iD = Convert.IsDBNull(row["id"]) ? 0 : (int)row["id"];

            // Kiểm tra nếu trường "dateCheckin" không phải NULL và ép kiểu sang DateTime?
            this.dateCheckIn = Convert.IsDBNull(row["dateCheckin"]) ? (DateTime?)null : (DateTime?)row["dateCheckin"];

            // Kiểm tra nếu trường "dateCheckOut" không phải NULL và ép kiểu sang DateTime?
            var dateCheckOutTemp = row["dateCheckOut"];
            this.dateCheckOut = Convert.IsDBNull(dateCheckOutTemp) ? (DateTime?)null : (DateTime?)dateCheckOutTemp;

            // Kiểm tra nếu trường "status" không phải NULL và ép kiểu sang int
            this.Status = Convert.IsDBNull(row["status"]) ? 0 : (int)row["status"];
            if(row["discount"].ToString() != "")
                this.Discount = (int)row["discount"];
        }

        private int discount;
        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        private int status;
        public int Status
        {
            get { return status; }
            set { status = value; }
        }


        private DateTime? dateCheckOut;
        public DateTime? DateCheckOut
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }


        private DateTime? dateCheckIn;
        public DateTime? DateCheckIn
        {
            get { return dateCheckIn; }
            set { dateCheckIn = value; }
        }
        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
