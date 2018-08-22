using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using HiQo.StaffManagement.Domain.EntitiesDTO;
using HiQo.StaffManagement.Domain.Service.Interfaces;
using HiQo.StaffManagement.Web.Core.Auth.Interfaces;
using HiQo.StaffManagement.Web.Core.Models;

namespace HiQo.StaffManagement.Web.Core.Auth
{
    public class AuthService : IAuthService
    {
        private readonly IUpsertUserService _service;
        private readonly string _salt;

        public AuthService(IUpsertUserService service)
        {
            _service = service;
            _salt = "hardbass";
        }

        public void RegisterUser(UserDto user)
        {
            user.Salt= Path.GetRandomFileName().Replace(".", "").Substring(0, 8);
            string passwordHash = GetPasswordHash(user.Password+user.Salt);
            user.Password = passwordHash;
            _service.Create(user);
        }

        public ClaimsIdentity CreateLoginIdentity(UserDto user, string authenticationType)
        {
            ICollection<Claim> claims=new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Email, user.Email));
            claims.Add(new Claim(ClaimTypes.Name, user.UserName));
            claims.Add(new Claim(ClaimTypes.Role, user.Role.Name));
            return new ClaimsIdentity(claims,authenticationType);
        }

        public UserDto IsUserExists(LogInViewModel user)
        {
            user.Password = GetPasswordHash(user.Password);
            return _service.GetToLogIn(user.Email, user.Password);
        }

        private string GetPasswordHash(string userPassword)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                var hash = md5.ComputeHash(Encoding.ASCII.GetBytes(userPassword + _salt));
                hash = md5.ComputeHash(hash);
                return BitConverter.ToString(hash);
            }
        }
    }
}
