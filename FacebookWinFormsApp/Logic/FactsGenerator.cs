using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BasicFacebookFeatures.Enums;

namespace BasicFacebookFeatures.Logic
{
    public class FactsGenerator
    {
        private readonly User r_LoggedInUser;
        private readonly List<eFactType> m_Facts;
        private int m_FactIndex;

        public FactsGenerator(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser ?? throw new ArgumentNullException(nameof(i_LoggedInUser));
            m_Facts = new List<eFactType>
            {
                eFactType.Friends,
                eFactType.Posts,
                eFactType.Age,
                eFactType.RelationshipStatus,
                eFactType.Hometown,
                eFactType.Gender,
                eFactType.Birthday,
                eFactType.ProfilePicture,
                eFactType.LikedPages,
                eFactType.Groups,
                eFactType.ZodiacSign 
            };

            m_FactIndex = 0;
        }

        public eFactType CurrentFact
        {
            get
            {
                return m_Facts[m_FactIndex == 0 ? m_Facts.Count - 1 : m_FactIndex - 1];
            }
        }

        private eZodiacSign getZodiacSign(DateTime i_Birthday)
        {
            int month = i_Birthday.Month;
            int day = i_Birthday.Day;

            eZodiacSign zodiacSign = eZodiacSign.Unknown; 

            switch (month)
            {
                case 1:
                    zodiacSign = day <= 19 ? eZodiacSign.Capricorn : eZodiacSign.Aquarius;
                    break;
                case 2:
                    zodiacSign = day <= 18 ? eZodiacSign.Aquarius : eZodiacSign.Pisces;
                    break;
                case 3:
                    zodiacSign = day <= 20 ? eZodiacSign.Pisces : eZodiacSign.Aries;
                    break;
                case 4:
                    zodiacSign = day <= 19 ? eZodiacSign.Aries : eZodiacSign.Taurus;
                    break;
                case 5:
                    zodiacSign = day <= 20 ? eZodiacSign.Taurus : eZodiacSign.Gemini;
                    break;
                case 6:
                    zodiacSign = day <= 20 ? eZodiacSign.Gemini : eZodiacSign.Cancer;
                    break;
                case 7:
                    zodiacSign = day <= 22 ? eZodiacSign.Cancer : eZodiacSign.Leo;
                    break;
                case 8:
                    zodiacSign = day <= 22 ? eZodiacSign.Leo : eZodiacSign.Virgo;
                    break;
                case 9:
                    zodiacSign = day <= 22 ? eZodiacSign.Virgo : eZodiacSign.Libra;
                    break;
                case 10:
                    zodiacSign = day <= 22 ? eZodiacSign.Libra : eZodiacSign.Scorpio;
                    break;
                case 11:
                    zodiacSign = day <= 21 ? eZodiacSign.Scorpio : eZodiacSign.Sagittarius;
                    break;
                case 12:
                    zodiacSign = day <= 21 ? eZodiacSign.Sagittarius : eZodiacSign.Capricorn;
                    break;
            }

            return zodiacSign;
        }

        public string ExecuteGenerator()
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

            eFactType currentFact = m_Facts[m_FactIndex];
            string fact = string.Empty;
            switch (currentFact)
            {
                case eFactType.Friends:
                    fact = r_LoggedInUser.Friends.Count > 0 ? $"You have {r_LoggedInUser.Friends.Count} friends!" : "You have no friends on Facebook.";
                    break;
                case eFactType.Posts:
                    fact = r_LoggedInUser.Posts.Count > 0 ? $"You've made {r_LoggedInUser.Posts.Count} posts so far!" : "You haven't made any posts yet.";
                    break;
                case eFactType.Age:
                    if (DateTime.TryParse(r_LoggedInUser.Birthday, out DateTime o_Birthday))
                    {
                        int age = DateTime.Now.Year - o_Birthday.Year;

                        if (o_Birthday.Date > DateTime.Now.AddYears(-age)) age--;
                        fact = $"You are {age} years old!";
                    }
                    break;
                case eFactType.RelationshipStatus:
                    fact = $"Your relationship status is: {r_LoggedInUser.RelationshipStatus}.";
                    break;
                case eFactType.Hometown:
                    fact = $"You live in {r_LoggedInUser.Hometown?.Name ?? "an unknown place"}!";
                    break;
                case eFactType.Gender:
                    fact = $"Your gender is: {r_LoggedInUser.Gender}.";
                    break;
                case eFactType.Birthday:
                    fact = $"You were born on {r_LoggedInUser.Birthday}!";
                    break;
                case eFactType.ProfilePicture:
                    fact = $"{r_LoggedInUser.Name}'s profile picture is:";
                    break;
                case eFactType.LikedPages: 
                    fact= $"You like {r_LoggedInUser.LikedPages.Count} pages.";
                    break;
                case eFactType.Groups: 
                    fact = $"You are a member of {r_LoggedInUser.Groups.Count} groups.";
                    break;
                case eFactType.ZodiacSign: 
                    if (DateTime.TryParse(r_LoggedInUser.Birthday, out DateTime o_ZodiacBirthday))
                    {
                        eZodiacSign zodiacSign = getZodiacSign(o_ZodiacBirthday);

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

