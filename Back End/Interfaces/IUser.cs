using AngularBigbang.Models.DTO;
using AngularBigbang.Models;
using AngularBigBang.Models;

namespace AngularBigbang.Interfaces
{
    public interface IUser
    {
        Task<User> Add(User user);
/*        Task<User> Update( int id, UserRegisterDTO user);
*/        Task<string> Delete(string username);
        Task<User> Get(UserDTO userDTO);
        Task<List<User>?> GetAll();
    }
}
