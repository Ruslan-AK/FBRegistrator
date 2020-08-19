using System.ComponentModel.DataAnnotations;

namespace FBRegistrator.Data.Context
{
    public class FBAccount
    {
        [Key]
        public long Id { get; set;}
        public string FullName {get; set;}
        public string Login {get; set;}
        public string Password {get; set;}
        public string PhoneNumber {get; set;}
    }
}