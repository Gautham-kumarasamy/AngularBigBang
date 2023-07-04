using AngularBigbang.Models.DTO;
using AngularBigBang.Models;
using AngularBigBang.Models.DTO;

namespace AngularBigBang.Interfaces
{
    public interface IDoctor
    {
        Task<Doctor> Add(Doctor doctor);
        Task<Doctor> Update(int id,Doctor doctor);
        Task<string> Delete(string username);
        Task<Doctor> Get(DoctorDTO doctorDTO);
        Task<List<Doctor>?> GetAll();
    }
}
