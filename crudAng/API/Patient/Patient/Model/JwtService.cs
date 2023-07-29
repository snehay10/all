//using Microsoft.IdentityModel.Tokens;
//using Patient.Context;
//using System.Data;
//using System.IdentityModel.Tokens.Jwt;
//using System.Security.Claims;
//using System.Text;

//namespace Patient.Model
//{
//    public class JwtService
//    {
        
        

//        public String SecreteKey { get; set; }
//        public int TokenDuration { get; set; }
//        private readonly IConfiguration config;
//        private AppDbContext context;

//        public JwtService( IConfiguration _config)
//        {
//            this.config = _config;
//            this.SecreteKey = config.GetSection("jwtConfig").GetSection("key").Value;
//            TokenDuration = Int32.Parse(config.GetSection("jwtConfig").GetSection("Duration").Value);
           
//        }

//        public JwtService(AppDbContext context)
//        {
//            this.context = context;
//        }

//        public String GenerateToken(string id , string FirstName ,string  LastName , string Email, string Mobile,string BloodGroup , string Gender ,string Password) 
//        {

//            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.SecreteKey));
//            var signature = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);
//            var payload = new[]
//            {
//            new Claim("id",id),
//            new Claim("firstname", FirstName),
//            new Claim("lastname", LastName),
//            new Claim("email", Email),
//            new Claim ("Mobile", Mobile),
//            new Claim("Password", Password),
//            new Claim("Gender",Gender),
//            new Claim("bloodGroup",BloodGroup)
//            };


//            var jwtToken = new JwtSecurityToken(issuer: "localhost",
//                audience: "localhost",
//                claims: payload,
//                expires: DateTime.Now.AddMinutes(TokenDuration),
//                signingCredentials: signature);

//            return new JwtSecurityTokenHandler().WriteToken(jwtToken);
//        }

        
//    }
//}
