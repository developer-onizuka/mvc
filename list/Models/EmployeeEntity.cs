namespace list.Models
{
	public class EmployeeEntity
	{
		public int EmployeeID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
	        public override string ToString()
        	{
		    return "EmployeeID:"+EmployeeID+" FirstName:"+FirstName+" LastName:"+LastName;
		}
	}
}
