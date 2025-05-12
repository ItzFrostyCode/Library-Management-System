namespace Library_Management_System
{
    internal class BorrowerDetailsForm
    {
        private long borrowerBookId;
        private string connectionString;

        public BorrowerDetailsForm(long borrowerBookId, string connectionString)
        {
            this.borrowerBookId = borrowerBookId;
            this.connectionString = connectionString;
        }
    }
}