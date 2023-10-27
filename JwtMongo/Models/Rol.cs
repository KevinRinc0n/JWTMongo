using AspNetCore.Identity.MongoDbCore.Models;
using MongoDB.Driver;
using MongoDbGenericRepository.Attributes;

namespace JwtMongo.Models;

[CollectionName("roles")]
public class Rol : MongoIdentityRole<Guid>
{
    
}
