using System;

namespace E_Shop.Models
{
    public class Employee
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string EmergencyContactNo { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Designation { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime ShiftId { get; set; }
        public string NId { get; set; }
        public long UserNameId { get; set; }
        public long PasswordId { get; set; }
        public long ImageId { get; set; }
        public long OutletId { get; set; }
        public long SalaryId { get; set; }
        public long EducationId { get; set; }
        public bool Status { get; set; }
        
    }
}