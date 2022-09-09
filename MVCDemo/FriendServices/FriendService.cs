using MVCDemo.Models;
using System.Xml.Linq;

namespace MVCDemo.FriendServices
{
    public class FriendService
    {
        static List<FriendModel> Friends { get; }
        static int nextId = 3;
        static FriendService()
        {
            Friends = new List<FriendModel>
                {
                    new FriendModel { FriendID = 123, FName = "Moni ", FPlace = " Ballari " },
                    new FriendModel { FriendID = 246, FName = " abc" , FPlace = " Ballari"  }

                };
        }

        public static List<FriendModel> GetAll() => Friends;

        public static FriendModel? Get(int id) => Friends.FirstOrDefault(f => f.FriendID == id);

        public static void Add(FriendModel friends)
        {
            friends.FriendID = nextId++;
            Friends.Add(friends);
        }

        public static void Delete(int id)
        {
            var friends = Get(id);
            if (friends is null)
                return;

            Friends.Remove(friends);
        }

        public static void Update(FriendModel friends)
        {
            var index = Friends.FindIndex(f => f.FriendID == friends.FriendID);
            if (index == -1)
                return;

            Friends[index] = friends;
        }

        internal static void Update(int friendID)
        {
            throw new NotImplementedException();
        }
    }

}
