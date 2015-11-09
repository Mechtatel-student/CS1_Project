namespace Domain.Entities.Clients
{
    public class Location
    {
        protected bool Equals(Location other)
        {
            return string.Equals(City, other.City) && string.Equals(Address, other.Address);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((City != null ? City.GetHashCode() : 0)*397) ^ (Address != null ? Address.GetHashCode() : 0);
            }
        }

        public string City { get; set; }
        public string Address { get; set; }

        public Location()
        {

        }

        public override string ToString()
        {
            return string.Format("{0} city {1}", City, Address);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Location) obj);
        }
    }

}
