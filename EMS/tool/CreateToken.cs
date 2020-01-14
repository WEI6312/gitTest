using JWT;
using JWT.Algorithms;
using JWT.Builder;
using JWT.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace EMS.tool
{
    public class CreateToken
    {
        public string create(int id,DateTime? date)
        {
            const string secret = "GQDstcKsx0NHjPOuXOYg5MbeJ1XT0uFiwDVvVBrk";
            var token = new JwtBuilder()
                .WithAlgorithm(new HMACSHA256Algorithm())
                .WithSecret(secret)
                .AddClaim("exp", date)
                .AddClaim("aud", id)
                .Build();
            return token;
        }
    }
}