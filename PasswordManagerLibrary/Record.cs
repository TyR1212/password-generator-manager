namespace PasswordManagerLibrary
{
    public class Record
    {
        public int ID { get; set; }
        public string Label { get; set; }
        public string Password { get; set; }

        public string DisplayLabel
        {
            get { return Label; }
        }
    }
}
