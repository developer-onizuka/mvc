//using MongoDB.Bson;
//using MongoDB.Driver;
//using MongoDB.Bson.Serialization;

namespace Employee_without_DB.Models
{
	public class EmployeeEntity 
        {
                //public ObjectId Id { get; set; }
                public int EmployeeID { get; set; }
                public string FirstName { get; set; }
                public string LastName { get; set; }
	        public override string ToString()
        	{
		    return "EmployeeID:"+EmployeeID+" FirstName:"+FirstName+" LastName:"+LastName;
		}
        }
}
