using System.Data;

namespace jwtDemo.Models
{
    public class userconstants
    {
        public static List<user> User = new List<user>()
        {
            new user()
            {
               UserName ="sneha_user",Email="snehauadav15@gmail.com",Name ="Sneha yadav ",Password="sneha@12",Role="user"
            },
             new user()
             {
                UserName = "jeevan_admin",Email="jeevan15@gmail.com",Name ="jeevan bhosale",Password="jeevan@12",Role="Admin"
             }
        };
    }
}
