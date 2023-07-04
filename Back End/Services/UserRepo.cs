using AngularBigbang.Exeptions;
using AngularBigbang.Interfaces;
using AngularBigbang.Models.DTO;
using AngularBigbang.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using AngularBigBang.Models;

namespace AngularBigbang.Services
{
    public class UserRepo : IUser
    {
        private readonly AngularBigBangContext _context;
        public UserRepo(AngularBigBangContext context)
        {
            _context = context;
        }
        public async Task<User?> Add(User user)
        {
            try
            {
                var users = _context.Users;
                var myUser = await users.SingleOrDefaultAsync(u => u.UserName == user.UserName);
                if (myUser == null)
                {
                    await _context.Users.AddAsync(user);
                    await _context.SaveChangesAsync();
                    return user;
                }
                return null;
            }
            catch (SqlException se) { throw new InvalidSqlException(se.Message); }
        }

        public async Task<string> Delete(string username)
        {
            try
            {
                var users = _context.Users;
                var myUser = users.SingleOrDefault(u => u.UserName == username);
                if (myUser != null)
                {
                    _context.Users.Remove(myUser);
                    _context.SaveChanges();
                    return "deleted successfully";
                }
                return "enter the correct username";
            }
            catch (SqlException se) { throw new InvalidSqlException(se.Message); }
        }

        public async Task<User?> Get(UserDTO userDTO)
        {
            try
            {
                var users = await GetAll();
                var user = users.FirstOrDefault(u => u.UserName == userDTO.UserName);
                if (user != null)
                {
                    return user;
                }
                return null;
            }
            catch (SqlException se) { throw new InvalidSqlException(se.Message); }
        }

        public async Task<List<User>?> GetAll()
        {
            try
            {
                var users = await _context.Users.ToListAsync();
                if (users != null)
                    return users;
                return null;
            }
            catch (SqlException se) { throw new InvalidSqlException(se.Message); }
        }

       /* public async Task<User> Update(int id, UserRegisterDTO user)
        {
            try
            {
                Newuser = new User();

                var Newuser = await _context.Users.FindAsync(id);
                
                    if (Newuser != null)
                    {
                        Newuser.Name = user.Name *//*!= null ? doctorupdate.Name : myUser.Name*//*;
                        Newuser.Role = user.Role != null ? user.Role : user.Role;
                        Newuser.Gender = user.Gender != null ? user.Gender : user.Gender;
                        Newuser.Email = user.Email != null ? user.Email : user.Email;
                        Newuser.UserName = user.UserName != null ? user.UserName : user.UserName;

                        await _context.SaveChangesAsync();
                        return Newuser;
                    }
                return null;

               

            }
            catch (SqlException se) { throw new InvalidSqlException(se.Message); }
        }*/
    }
}
