using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class nameAndAddress : IComparable, IEquatable<nameAndAddress>
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string address { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string zipCode { get; set; }
    public string phoneNumber { get; set; }
    public string idNumber { get; set; }

    //compares lastnames
    public int CompareTo(object obj)
    {
        nameAndAddress namein = (nameAndAddress)obj;

        return this.lastName.CompareTo(namein.lastName);
    }

    public bool Equals(nameAndAddress other)
    {
        if (Object.ReferenceEquals(other, null)) return false;

        if (Object.ReferenceEquals(this, other)) return true;

        return (this.firstName.Equals(other.firstName) && this.lastName.Equals(other.lastName));

    }

    // creates a hashcode of firstname and last name
    public override int GetHashCode()
    {
        int hashFirstName = this.firstName == null ? 0 : this.firstName.GetHashCode();

        int hashLastName = lastName.GetHashCode();
        return hashFirstName ^ hashLastName; 
    }
}
 
