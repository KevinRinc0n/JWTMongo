using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;

namespace JwtMongo.Models;

[CollectionName("users")]
public class User : MongoIdentityUser<Guid>
{
    public string FullName { get; set; } = string.Empty;
}