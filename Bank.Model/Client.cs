using Bank.Base.Enum;

namespace Bank.Model
{
    public class Client
    {
        public Bank Bank { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PESEL { get; set; }
        public ESexType Sex { get; set; }
    }
}