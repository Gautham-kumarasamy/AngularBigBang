using AngularBigbang.Models.DTO;
using AngularBigBang.Models;
using AngularBigBang.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace AngularBigBang.Interfaces
{
    public interface IDoctorService
    {
        Task<UserDTO> Register(Doctor doctorRegisterDTO);

        Task<Doctor?> staffRegister(Doctor doctorRegisterDTO);

        Task<List<Doctor>> View_All_StaffRequest();
        Task<Doctor?> deletestaffinlist(Doctor doctorRegisterDTO);

        Task<List<Doctor>> View_All_doctors();

         Task<string> DeleteDoctors(string username);

        Task<Doctor> UpdateDoctor( int id,Doctor doctorupdate);



    }
}
