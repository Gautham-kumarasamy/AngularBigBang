using AngularBigbang.Exeptions;
using AngularBigbang.Interfaces;
using AngularBigbang.Models.DTO;
using AngularBigBang.Interfaces;
using AngularBigBang.Models;
using AngularBigBang.Models.DTO;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AngularBigBang.Services
{
    public class DoctorRepo:IDoctor
    {
        private readonly AngularBigBangContext _context;

        public DoctorRepo(AngularBigBangContext context)
        {
            _context = context;
        }
        public async Task<Doctor?> Add(Doctor doctor)
        {
            try
            {
                var Doctors = _context.Doctors;
                var myDoctor = await Doctors.SingleOrDefaultAsync(u => u.UserName == doctor.UserName);
                if (myDoctor == null)
                {
                    await _context.Doctors.AddAsync(doctor);
                    await _context.SaveChangesAsync();
                    return doctor;
                }
                return null;
            }
            catch (SqlException se) { throw new InvalidSqlException(se.Message); }
        }

        public async  Task<string> Delete(string username)
        {
            try
            {
                var Doctors = _context.Doctors;
                var myDoctor = Doctors.SingleOrDefault(u => u.UserName == username);
                if (myDoctor != null)
                {
                    _context.Doctors.Remove(myDoctor);
                    _context.SaveChanges();
                    return "deleted successfully";
                }
                return "enter the correct username";
            }
            catch (SqlException se) { throw new InvalidSqlException(se.Message); }
        }

        public async Task<Doctor?> Get(DoctorDTO doctorDTO)
        {
            try
            {
                var Doctors = await GetAll();
                var Doctor = Doctors.FirstOrDefault(u => u.UserName == doctorDTO.UserName);
                if (Doctor != null)
                {
                    return Doctor;
                }
                return null;
            }
            catch (SqlException se) { throw new InvalidSqlException(se.Message); }
        }

        public async Task<List<Doctor>?> GetAll()
        {
            try
            {
                var Doctors = await _context.Doctors.ToListAsync();
                if (Doctors != null)
                    return Doctors;
                return null;
            }
            catch (SqlException se) { throw new InvalidSqlException(se.Message); }
        }

        public async Task<Doctor> Update( int id,Doctor doctor)
        {
            try
            {
                var NewDoctor = await _context.Doctors.FindAsync(id);

                    NewDoctor.Password = doctor.Password != null ? doctor.Password : NewDoctor.Password;
                    NewDoctor.Name = doctor.Name /*!= null ? doctorupdate.Name : myUser.Name*/;
                    NewDoctor.Role = doctor.Role != null ? doctor.Role : NewDoctor.Role;
                    NewDoctor.Gender = doctor.Gender != null ? doctor.Gender : NewDoctor.Gender;
                    NewDoctor.Email = doctor.Email != null ? doctor.Email : NewDoctor.Email;
                    NewDoctor.UserName = doctor.UserName != null ? doctor.UserName : NewDoctor.UserName;
                    NewDoctor.RequestStatus = doctor.RequestStatus != null ? doctor.RequestStatus : NewDoctor.RequestStatus;
                    NewDoctor.Availability = doctor.Availability != null ? doctor.Availability : NewDoctor.Availability;
                    NewDoctor.Specialization = doctor.Specialization != null ? doctor.Specialization : NewDoctor.Specialization;
                    NewDoctor.Experiance = doctor.Experiance == doctor.Experiance ? NewDoctor.Experiance : doctor.Experiance;
                    await _context.SaveChangesAsync();
                    return NewDoctor;
               
            }
            catch (SqlException se) { throw new InvalidSqlException(se.Message); }
        }
    }
}
