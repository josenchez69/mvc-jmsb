using mvc_jmsb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace mvc_jmsb.Services
{
    public class JMSBValidation
    {
        /*
        readonly HttpContext _httpContext;
        readonly Cryptography _cryptography;
        readonly AuthOptions _authConfiguration;
        readonly EZCourseContext _context;
        public JMSBValidation(
            IHttpContextAccessor contextAccessor,
            Cryptography cryptography,
            IOptions<AuthOptions> authConfiguration,
            EZCourseContext context)
        {
            _httpContext = contextAccessor.HttpContext;
            _cryptography = cryptography;
            _authConfiguration = authConfiguration.Value;
            _context = context;
        }
        */
        public bool SignIn(string email, string password)
        {
            var prueba = email;
            var prueba2 = password;
            /*var user = _context.User.Include(u => u.UserCredential).FirstOrDefault(u => u.Email == email);

            if (user == null) return false;

            var userCredential = user.UserCredential;
            var claimedPasswordHashed = _cryptography.HashSHA256(password + userCredential.PasswordSalt);

            if (claimedPasswordHashed != userCredential.HashedPassword) return false;

            var permissions = _context.UserPermission.Where(up => up.UserId == user.Id)
                                    .Select(up => up.Permission.Code).ToList();

            AuthInfo authInfo = new AuthInfo()
            {
                UserId = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Claims = new Dictionary<string, string>(),
                Permissions = permissions,
            };
            
            _httpContext.Response.Cookies.Append("ezAuthToken", AuthInfoToToken(authInfo));*/
            return true;
        }
    }
}
