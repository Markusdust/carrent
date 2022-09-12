namespace CarRent.Customer
{
    public class Customer
    {
        public Guid Id { get; }

        public string PassportNumber { get; }

        public string Firstname { get; }

        public string Lastname { get; }


        public Customer(Guid Id, string passportNumber, string firstname,
                                                        string lastname)
        {
            this.Id = Id;
            this.PassportNumber = passportNumber;
            this.Firstname = firstname;
            this.Lastname = lastname;
        }
    }
}
