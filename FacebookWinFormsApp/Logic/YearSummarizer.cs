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
        private int m_CurrentProfilePhotoIndex = 0;
        private int m_CurrentPostIndex = 0;

        public List<Photo> ProfilePhotosListByYear { get; private set; }

        public List<Post> PostListByYear { get; private set; }

        public int CurrentYear { get; set; }

        public YearSummarizer(User i_User)
        {
            r_LoggedInUser = i_User;
        }

        public void PopulateLists(int i_Year)
        {
            if (CurrentYear != i_Year)
            {
                fetchProfilePhotosByYear(i_Year);
                fetchPostsByYear(i_Year);
            }

        }

        private void fetchProfilePhotosByYear(int i_Year)
        {
            List<Photo> profilePhotos = new List<Photo>();

            if(r_LoggedInUser.Albums != null)
            {
                foreach(Album album in r_LoggedInUser.Albums)
                {
                    if(album.Type == Album.eType.Profile && album.Photos != null)
                    {
                        foreach(Photo photo in album.Photos)
                        {
                            if(photo.CreatedTime.HasValue && photo.CreatedTime.Value.Year == i_Year)
                            {
                                profilePhotos.Add(photo);
                            }
                        }
                    }
                }
            }

            profilePhotos
                .Where(photo => photo.CreatedTime.HasValue)
                .OrderBy(photo => photo.CreatedTime.Value)
                .ToList();
            this.ProfilePhotosListByYear = profilePhotos;
        }

        private void fetchPostsByYear(int i_Year)
        {
            List<Post> postsByYear = new List<Post>();

            if (r_LoggedInUser.Posts != null)
            {
                foreach (Post post in r_LoggedInUser.Posts)
                {
                    if (post.CreatedTime.HasValue && post.CreatedTime.Value.Year == i_Year)
                    {
                        postsByYear.Add(post);
                    }
                }
            }

            postsByYear
                .Where(post => post.CreatedTime.HasValue)
                .OrderBy(post => post.CreatedTime.Value)
                .ToList();
            this.PostListByYear = postsByYear;
        }

        public Photo GetFirstProfilePhoto()
        {
            if(ProfilePhotosListByYear != null)
            {
                return ProfilePhotosListByYear[0];
            }

            return null;
        }

        //TODO: Maybe code duplication? check with chat
        public Photo GetPreviousProfilePhoto()
        {
            if (ProfilePhotosListByYear != null && ProfilePhotosListByYear.Count > 0 && m_CurrentProfilePhotoIndex != 0)
            {
                m_CurrentProfilePhotoIndex--;
            }

            return ProfilePhotosListByYear[m_CurrentPostIndex];
        }

        public Photo GetNextProfilePhoto()
        {
            if (ProfilePhotosListByYear != null && ProfilePhotosListByYear.Count > 0 && (m_CurrentProfilePhotoIndex + 1) != ProfilePhotosListByYear.Count)
            {
                m_CurrentProfilePhotoIndex++;
            }

            return ProfilePhotosListByYear[m_CurrentPostIndex];
        }

        public Post GetFirstPost()
        {
            if (PostListByYear != null)
            {
                return PostListByYear[0];
            }

            return null;
        }
    }
}
