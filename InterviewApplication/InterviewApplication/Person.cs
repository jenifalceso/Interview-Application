using System.Collections.Generic;
using System.Linq;

namespace InterviewApplication
{
    public class Person
    {
        private string Area { get; set; }
        private string Type { get; set; }
        private string Code { get; set; }
        private string PIC { get; set; }
        public IList<Person> PersonList;

        public Person()
        {

        }

        public Person(string area, string type, string code, string pic)
        {
            Area = area;
            Type = type;
            Code = code;
            PIC = pic;
        }

        // Retrieves the user in charge
        public string RetrieveUser(string area, string type, string code = "")
        {
            // Returns error if parameter is not valid
            if (string.IsNullOrEmpty(area) || string.IsNullOrEmpty(type))
            {
                return "parameter cannot be null";
            }
            else if (!(area.Length == 3) || !(type.Length == 3) || (!string.IsNullOrEmpty(code) && !(code.Length == 3)))
            {
                return "Input entered doesn't match 3 character limit";
            }

            string name = (from c in PersonList
                           where c.Area == area.ToUpper() && c.Type == type.ToUpper() && c.Code == code.ToUpper()
                           select c.PIC).FirstOrDefault();

            // Returns error if parameter does not exists
            if (string.IsNullOrEmpty(name)){
                return "PIC not found.";
            }
            
            return "PIC In Charge: " + name;
        }
    }
}
