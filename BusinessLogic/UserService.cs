using BusinessLogic.Contracts.In;
using BusinessLogic.Contracts.Out;
using DataAccessLayer;

namespace BusinessLogic;

public class UserService
{
    private readonly UserRepository _userRepository = new();
    
    public void Register(UserDtoIn userDtoIn) 
        => _userRepository.AddUser(userDtoIn.Name, userDtoIn.Password);

    public IEnumerable<UserDtoOut> GetAllPeople() => new List<UserDtoOut>();
}