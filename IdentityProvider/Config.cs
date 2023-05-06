using IdentityModel;
using IdentityServer4.Test;
using static IdentityServer4.Models.IdentityResources;
using System.Security.Claims;

namespace IdentityProvider
{
    public class Config
    {

        public static List<TestUser> GetUsers()
                        => new List<TestUser>
                        {
                            new TestUser
                            {
                                SubjectId = "{223C9865-03BE-4951-8911-740A438FCF9D}",
                                Username = "peter@u2u.be",
                                Password = "u2u-secret",
                                Claims = new List<Claim>
                                {
                                    new Claim("given_name", "Peter"),
                                    new Claim(JwtClaimTypes.Name, "Peter Himschoot"),
                                    new Claim("family_name", "Himschoot"),
                                }
                            },
                            new TestUser
                            {
                                SubjectId = "{34119795-78A6-44C2-B128-30BFBC29139D}",
                                Username = "student@u2u.be",
                                Password = "u2u-secret",
                                Claims = new List<Claim>
                                {
                                new Claim("given_name", "Student"),
                                new Claim(JwtClaimTypes.Name, "Student Blazor"),
                                new Claim("family_name", "Blazor"),
                                }
                            }
                        };
    }
}
