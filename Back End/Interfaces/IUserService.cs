using AngularBigbang.Models.DTO;
using AngularBigBang.Models;
using AngularBigBang.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace AngularBigbang.Interfaces
{
    public interface IUserService
    {
        Task<UserDTO> Register(UserRegisterDTO userRegisterDTO);
        Task<UserDTO> LogIN(UserDTO userDTO);
/*        Task<User> UpdateUser(int id, UserRegisterDTO userupdate);
*//*        Task<bool> Update_Password(UserDTO userRegisterDTO);
*/
        Task<UserRegisterDTO?> staffRegister(UserRegisterDTO userRegisterDTO,StaffDTO staffDTO);

        Task<List<UserRegisterDTO>> View_All_StaffRequest(StaffDTO staffDTO);
        Task<UserRegisterDTO?> deletestaffinlist(UserRegisterDTO userRegisterDTO);

        Task<string> DeleteUser(string username);



    }
}
