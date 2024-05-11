using System;
namespace SchoolProjectClient.Client.Model.Crypto
{
    public class Crypto
    {
        public string Symbol { get; set; }
        public string Price { get; set; }


        public float Cost { get; set; }
        public float Amount { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}

