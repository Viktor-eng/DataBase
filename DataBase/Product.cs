namespace DataBase
{
    class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int IdFolder { get; set; }

        public int IdProductGroups { get; set; }

        public int IdBrand { get; set; }

        public bool Archive { get; set; }
    }
}
