using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Logic
{
    public class FactGenerator
    {
        public enum FactType
        {
            Friends,
            Posts,
            Age,
            RelationshipStatus,
            Hometown,
            Gender,
            Birthday,
            ProfilePicture,
            LikedPages, 
            Groups,
            ZodiacSign
        }

        private readonly User r_LoggedInUser;
        private readonly List<FactType> m_Facts;
        private int m_FactIndex;

        public FactGenerator(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser ?? throw new ArgumentNullException(nameof(i_LoggedInUser));
            m_Facts = new List<FactType>
            {
                FactType.Friends,
                FactType.Posts,
                FactType.Age,
                FactType.RelationshipStatus,
                FactType.Hometown,
                FactType.Gender,
                FactType.Birthday,
                FactType.ProfilePicture,
                FactType.LikedPages,
                FactType.Groups,
                FactType.ZodiacSign 
            };

            m_FactIndex = 0;
        }

        public FactType CurrentFact
        {
            get
            {
                if (m_FactIndex == 0)
                {
                    return m_Facts[m_Facts.Count - 1]; 
                }

                return m_Facts[m_FactIndex - 1];
            }
        }

        private string getZodiacSign(DateTime birthday)
        {
            int month = birthday.Month;
            int day = birthday.Day;
            string zodiacSign = "Unknown";

            switch (month)
            {
                case 1:
                    zodiacSign = day <= 19 ? "Capricorn" : "Aquarius";
                    break;
                case 2:
                    zodiacSign = day <= 18 ? "Aquarius" : "Pisces";
                    break;
                case 3:
                    zodiacSign = day <= 20 ? "Pisces" : "Aries";
                    break;
                case 4:
                    zodiacSign = day <= 19 ? "Aries" : "Taurus";
                    break;
                case 5:
                    zodiacSign = day <= 20 ? "Taurus" : "Gemini";
                    break;
                case 6:
                    zodiacSign = day <= 20 ? "Gemini" : "Cancer";
                    break;
                case 7:
                    zodiacSign = day <= 22 ? "Cancer" : "Leo";
                    break;
                case 8:
                    zodiacSign = day <= 22 ? "Leo" : "Virgo";
                    break;
                case 9:
                    zodiacSign = day <= 22 ? "Virgo" : "Libra";
                    break;
                case 10:
                    zodiacSign = day <= 22 ? "Libra" : "Scorpio";
                    break;
                case 11:
                    zodiacSign = day <= 21 ? "Scorpio" : "Sagittarius";
                    break;
                case 12:
                    zodiacSign = day <= 21 ? "Sagittarius" : "Capricorn";
                    break;
            }

            return zodiacSign;
        }

        public string executeGenerator()
        {
            string randomFact = string.Empty;

            if (r_LoggedInUser != null)
            {
                randomFact = GenerateNextFact();
            }
            else
            {
                MessageBox.Show("Please log in first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return randomFact;
        }

        public string GenerateNextFact()
        {

            if (r_LoggedInUser == null)
            {
                throw new InvalidOperationException("User is not logged in.");
            }

            if (m_FactIndex >= m_Facts.Count)
            {
                m_FactIndex = 0;
            }

            FactType currentFact = m_Facts[m_FactIndex];
            string fact = string.Empty;

            switch (currentFact)
            {
                case FactType.Friends:
                    fact = r_LoggedInUser.Friends.Count > 0 ? $"You have {r_LoggedInUser.Friends.Count} friends!" : "You have no friends on Facebook.";
                    break;
                case FactType.Posts:
                    fact = r_LoggedInUser.Posts.Count > 0 ? $"You've made {r_LoggedInUser.Posts.Count} posts so far!" : "You haven't made any posts yet.";
                    break;
                case FactType.Age:
                    if (DateTime.TryParse(r_LoggedInUser.Birthday, out DateTime io_birthday))
                    {
                        int age = DateTime.Now.Year - io_birthday.Year;

                        if (io_birthday.Date > DateTime.Now.AddYears(-age)) age--;
                        fact = $"You are {age} years old!";
                    }
                    break;
                case FactType.RelationshipStatus:
                    fact = $"Your relationship status is: {r_LoggedInUser.RelationshipStatus}.";
                    break;
                case FactType.Hometown:
                    fact = $"You live in {r_LoggedInUser.Hometown?.Name ?? "an unknown place"}!";
                    break;
                case FactType.Gender:
                    fact = $"Your gender is: {r_LoggedInUser.Gender}.";
                    break;
                case FactType.Birthday:
                    fact = $"You were born on {r_LoggedInUser.Birthday}!";
                    break;
                case FactType.ProfilePicture:
                    fact = $"{r_LoggedInUser.Name}'s profile picture is:";
                    break;
                case FactType.LikedPages: 
                    fact= $"You like {r_LoggedInUser.LikedPages.Count} pages.";
                    break;
                case FactType.Groups: 
                    fact = $"You are a member of {r_LoggedInUser.Groups.Count} groups.";
                    break;
                case FactType.ZodiacSign: 
                    if (DateTime.TryParse(r_LoggedInUser.Birthday, out DateTime io_zodiacBirthday))
                    {
                        string zodiacSign = getZodiacSign(io_zodiacBirthday);
                        fact = $"Your zodiac sign is {zodiacSign}!";
                    }
                    else
                    {
                        fact = "Unable to determine your zodiac sign.";
                    }
                    break;
                default:
                    return "Fact unavailable.";
            }

            m_FactIndex++;

            return fact;
        }
    }
}

