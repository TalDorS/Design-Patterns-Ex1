using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Logic
{
    public class YearSummarizer
    {
        private readonly User r_LoggedInUser;
        private int m_CurrentProfilePhotoIndex;
        private int m_CurrentPostIndex;
        private int m_CurrentEventIndex;

        public List<Photo> ProfilePhotosListByYear { get; private set; }
        public List<Post> PostListByYear { get; private set; }
        public List<Event> EventsListByYear { get; private set; }
        public int CurrentYear { get; private set; }

        public YearSummarizer(User i_User)
        {
            r_LoggedInUser = i_User ?? throw new ArgumentNullException(nameof(i_User), "Logged-in user cannot be null");
        }

        public void PopulateLists(int i_Year)
        {
            if (CurrentYear != i_Year)
            {
                CurrentYear = i_Year;
                fetchProfilePhotosByYear(i_Year);
                fetchPostsByYear(i_Year);
                fetchEventsListByYear(i_Year);
            }
        }

        private void fetchProfilePhotosByYear(int i_Year)
        {
            ProfilePhotosListByYear = r_LoggedInUser.Albums?
                                          .Where(i_Album => i_Album.Type == Album.eType.Profile && i_Album.Photos != null)
                                          .SelectMany(i_Album => i_Album.Photos)
                                          .Where(i_Photo => i_Photo.CreatedTime.HasValue && i_Photo.CreatedTime.Value.Year == i_Year)
                                          .OrderBy(i_Photo => i_Photo.CreatedTime.Value)
                                          .ToList() ?? new List<Photo>();
        }

        private void fetchPostsByYear(int i_Year)
        {
            PostListByYear = r_LoggedInUser.Posts?
                                 .Where(i_Post => i_Post.CreatedTime.HasValue
                                                  && i_Post.CreatedTime.Value.Year == i_Year
                                                  && i_Post.Type == Post.eType.status)
                                 .OrderBy(i_Post => i_Post.CreatedTime.Value)
                                 .ToList() ?? new List<Post>();
        }

        private void fetchEventsListByYear(int i_Year)
        {
            EventsListByYear = r_LoggedInUser.Events?
                                   .Where(i_EventItem =>
                                       i_EventItem.StartTime.HasValue && i_EventItem.StartTime.Value.Year == i_Year
                                       || i_EventItem.StartTime.HasValue && i_EventItem.StartTime.Value.Year == i_Year)
                                   .OrderBy(i_EventItem => i_EventItem.StartTime ?? i_EventItem.StartTime)
                                   .ToList() ?? new List<Event>();
        }

        public Event GetFirstEvent() => EventsListByYear?.FirstOrDefault();

        public Photo GetFirstProfilePhoto() => ProfilePhotosListByYear?.FirstOrDefault();

        public Post GetFirstPost() => PostListByYear?.FirstOrDefault(i_Post => i_Post.Type == Post.eType.status);

        public Photo GetNextProfilePhoto() => getNextItem(ProfilePhotosListByYear, ref m_CurrentProfilePhotoIndex);

        public Photo GetPreviousProfilePhoto() => getPreviousItem(ProfilePhotosListByYear, ref m_CurrentProfilePhotoIndex);

        public Post GetNextPost() => getNextItem(PostListByYear, ref m_CurrentPostIndex);

        public Post GetPreviousPost() => getPreviousItem(PostListByYear, ref m_CurrentPostIndex);

        private T getNextItem<T>(List<T> i_List, ref int io_Index)
        {
            if (i_List == null || i_List.Count == 0 || io_Index >= i_List.Count - 1)
            {
                return default;
            }

            return i_List[++io_Index];
        }

        private T getPreviousItem<T>(List<T> i_List, ref int io_Index)
        {
            if (i_List == null || i_List.Count == 0 || io_Index <= 0)
            {
                return default;
            }

            return i_List[--io_Index];
        }
    }

}
