using Bank.Base.Enum;

namespace Bank.Model
{
    /// <summary>
    /// Historia
    /// </summary>
    public class History
    {
        public BankAccount BankAccount { get; set; }
        public string Description { get; set; }
        public object Object { get; set; }
        public EHstoryType ObjectType { get; set; }
    }
}