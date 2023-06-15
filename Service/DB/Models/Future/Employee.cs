using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Employee
    {
        public Employee()
        {
            EmployeeDrawers = new HashSet<EmployeeDrawer>();
            EmployeeRates = new HashSet<EmployeeRate>();
        }

        public Guid EmployeeId { get; set; }
        public int StoreId { get; set; }
        public short EmpId { get; set; }
        public short OldPassword { get; set; }
        public short SecurityLevel { get; set; }
        public string? Badge { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleInitial { get; set; }
        public short Class { get; set; }
        public short PriceLevel { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? UserInfo { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? Phone { get; set; }
        public byte[]? Ssn { get; set; }
        public string? IceName { get; set; }
        public string? IcePhone { get; set; }
        public byte GslfirstRoom { get; set; }
        public byte GslcurrRoom { get; set; }
        public byte IsInactive { get; set; }
        public short UpperLeftX { get; set; }
        public short UpperLeftY { get; set; }
        public byte WindowOrientation { get; set; }
        public bool FingerprintRequiresId { get; set; }
        public string? Address { get; set; }
        public byte[]? FingerPrintData { get; set; }
        public byte[]? FrontEndPassword { get; set; }
        public byte[]? BackOfficePassword1 { get; set; }
        public byte[]? BackOfficePassword2 { get; set; }
        public byte[]? BackOfficePassword3 { get; set; }
        public byte[]? BackOfficePassword4 { get; set; }
        public DateTime? PasswordChanged { get; set; }
        public byte BadPasswordCount { get; set; }
        public DateTime? LockedOut { get; set; }
        public bool NeedEncrypted { get; set; }
        public DateTime? LastBadPwdate { get; set; }
        public bool RequireFingerprintForClockInOut { get; set; }
        public string? Email { get; set; }
        public string? CellPhone { get; set; }
        public int CellProvider { get; set; }
        public int AlertPreference { get; set; }
        public bool IsClockInExempt { get; set; }
        public byte[]? Salt { get; set; }
        public byte[]? FrontEndHash { get; set; }
        public byte[]? BackOfficeHash1 { get; set; }
        public byte[]? BackOfficeHash2 { get; set; }
        public byte[]? BackOfficeHash3 { get; set; }
        public byte[]? BackOfficeHash4 { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? ReviewDate { get; set; }
        public string? Notes { get; set; }

        public virtual ICollection<EmployeeDrawer> EmployeeDrawers { get; set; }
        public virtual ICollection<EmployeeRate> EmployeeRates { get; set; }
    }
}
