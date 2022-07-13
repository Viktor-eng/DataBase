using System;

namespace DataBase
{
    class Order
    {
        public int Id { get; set; }

        public int IdOrganization { get; set; }

        public int IdManager { get; set; }

        public string OrderNumber { get; set; }

        public DateTime dateTime { get; set; }
    }
}
