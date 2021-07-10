using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07_Task4_Booking.Com.Models
{
    class Purchase: Book
    {
        Guid _id;
        Guid _relatedBookId;
        String _relatedLoginName;
        bool _payment;

        public Guid Id
        {
            get { return _id; }
            set { Id = value; }
        }
        public Guid RelatedBookId
        {
            get { return _relatedBookId; }
            set { RelatedBookId = value; }
        }
        public String RelatedLoginName
        {
            get { return _relatedLoginName; }
            set { RelatedLoginName = value; }
        }
        public bool Payment
        {
            get { return _payment; }
            set { Payment = value; }
        }
        public Purchase(Guid relatedBookId, string relatedLoginName, bool payment)
        {
            RelatedBookId = relatedBookId;
            RelatedLoginName = relatedLoginName;
            Payment = payment;
        }
        public void ConfirmSuccessPurchase()
        {
            if (Payment == true)
                Console.WriteLine("The payment was completed successfully.");
            else
                Console.WriteLine("The payment was unsuccessful.");
        }
    }
}
