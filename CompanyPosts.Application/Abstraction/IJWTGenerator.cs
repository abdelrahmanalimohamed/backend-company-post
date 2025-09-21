namespace CompanyPosts.Application.Abstraction;
public interface IJWTGenerator
{
	string CreateToken(Guid userId);
}