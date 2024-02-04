using FriendOrganizer.Model;
using FriendOrganizer.UI.Data;
using System.Collections.ObjectModel;

namespace FriendOrganizer.UI.ViewModel
{
    public class MainViewModel
    {
        private readonly IFriendDataService _friendDataService;

        private Friend friend;

        public MainViewModel(IFriendDataService friendDataService)
        {
            Friends = new ObservableCollection<Friend>();
            _friendDataService = friendDataService;
        }

        public void Load()
        {
            var friends = _friendsDataService.GetAll();
            Friends.Clear();
            foreach (var firnd in friends)
            {
                Friends.Add(friend);
            }
        }
        public ObservableCollection<Friend> Friends { get; set; }
    }
}