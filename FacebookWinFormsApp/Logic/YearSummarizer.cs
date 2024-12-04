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

        public YearSummarizer(User i_User)
        {
            r_LoggedInUser = i_User;
        }

        public List<Photo> GetProfilePhotosByYear(int i_Year)
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

            return profilePhotos
                .Where(photo => photo.CreatedTime.HasValue)
                .OrderBy(photo => photo.CreatedTime.Value)
                .ToList();
        }
    }
}
