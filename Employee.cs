namespace EmployeesV10
{
    public class Employee
    {
        #region Instance fields
        public string _name;
        public int _hoursPerWeek;
        #endregion

        #region Contructor
        public Employee (string name, int hoursPerWeek)
        {
            _name = name;
            _hoursPerWeek = hoursPerWeek;
        }
            
        #endregion

        #region Properties
           public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int HoursPerWeek
        {
            get { return _hoursPerWeek; }
            set { _hoursPerWeek = value; }
        }

        #endregion


    }
}