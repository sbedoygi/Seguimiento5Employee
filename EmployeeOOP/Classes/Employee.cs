namespace EmployeeOOP.Classes
{
    public abstract class Employee
    {
        #region Properties

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Date BirthDate { get; set; }
        public Date HiringDate { get; set; }
        public bool IsActive { get; set; }

        #endregion

        #region Methods

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return  $"INFORMACIÓN DEL EMPLEADO \n\t " +
                    $"ID: {Id} \n\t " +
                    $"Nombres: {FirstName} \n\t " +
                    $"Apellidos: {LastName} \n\t " +
                    $"Fecha cumpleaños: {BirthDate} \n\t " +
                    $"Fecha Contratación: {HiringDate} \n\t " +
                    $"¿Empleado Activo?: {IsActive}";
        }

        #endregion
    }
}
