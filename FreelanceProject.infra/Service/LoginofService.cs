using FreelanceProject.Core.Data;
using FreelanceProject.Core.Repository;
using FreelanceProject.Core.Service;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FreelanceProject.infra.Service
{
    public class LoginofService : ILoginofService
    {
        private readonly ILoginofRepository loginofRepository;
        public LoginofService(ILoginofRepository loginofRepository)
        {
            this.loginofRepository = loginofRepository;
        }

        public string Auth(Loginof loginof)
        {

            var result = loginofRepository.Auth(loginof);
            if (result == null)
            {
                return null;
            }
            else
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));

                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                var claims = new List<Claim>{
                    new Claim("username", result.Username),
                 new Claim("role", result.Id_Role.ToString())
};
                var tokeOptions = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddSeconds(10),
                signingCredentials: signinCredentials
                );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);

                return tokenString;
            
        } 
        
        
        }

        public void delete(int id)
        {
            loginofRepository.delete(id);
        }

        public List<Loginof> GetAll()
        {
            return loginofRepository.GetAll();
        }

        public Loginof GetById(int id)
        {
           return loginofRepository.GetById(id);
        }

        public int insert(Loginof loginof)
        {
            return loginofRepository.insert(loginof);
        }

        public void update(Loginof loginof)
        {
            loginofRepository.update(loginof);
        }
    }
}
