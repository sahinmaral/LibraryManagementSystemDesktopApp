namespace LibraryManagementSystem.Properties
{
    class ConnectionClass
    {

        public string Address = System.IO.File.ReadAllText(@"C:\SqlAddress.txt");

        public string DeleteOrderQuery = "UPDATE book SET " +
            "st_id=@st_id , " +
            "taken_date=@taken_date, " +
            "book_name=@book_name , " +
            "is_delivered=@is_delivered, " +
            "delivery_date=@delivery_date " +
            "where";

        


    }
}
