using FriendOrganizer.Model;
using System.Collections.Generic;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            //TO DO: load data from real database
            yield return new Friend { FirstName = "Maria", LastName = "Boros" };
            yield return new Friend { FirstName = "Stefan", LastName = "Simbanu" };
            yield return new Friend { FirstName = "Madalina", LastName = "Simion" };
            yield return new Friend { FirstName = "Daria", LastName = "Manolache" };
        }
    }
}
