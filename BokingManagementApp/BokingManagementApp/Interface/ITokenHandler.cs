using System.Security.Claims;

namespace BokingManagementApp.Interface
{
    public interface ITokenHandler
    {
        public string GenerateToken(IEnumerable<Claim> claims);
    }
}
