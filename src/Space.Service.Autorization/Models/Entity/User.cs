using Space.Service.Autorization.Enums;
namespace Space.Service.Autorization.Models.Entity
{
    public class User
    {
        Guid Id { get; set; } = new Guid();
        // Profile data
        public string Name { get; set; }
        public string LastName { get; set; }
        public UserRole Role { get; set; }
        //

        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }    
        public bool Email_Verified { get; set; }
        public bool Phone_Verified { get; set; }
        public bool Is_Active { get; set; }

    }
}
