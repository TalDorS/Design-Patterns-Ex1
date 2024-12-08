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

        private eZodiacSign getZodiacSign(DateTime i_Birthdate)
        {
            int month = i_Birthdate.Month;
            int day = i_Birthdate.Day;
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
            string fact = getFact(currentFact);

            m_FactIndex++;

            return fact;
        }

        private string getFact(eFactType io_CurrentFact)
        {
            string fact = string.Empty;

            switch (io_CurrentFact)
            {
                case eFactType.Friends:
                    fact = generateFriendsFact();
                    break;
                case eFactType.Posts:
                    fact = generatePostsFact();
                    break;
                case eFactType.Age:
                    fact = generateAgeFact();
                    break;
                case eFactType.RelationshipStatus:
                    fact = generateRelationshipStatusFact();
                    break;
                case eFactType.Hometown:
                    fact = generateHometownFact();
                    break;
                case eFactType.Gender:
                    fact = generateGenderFact();
                    break;
                case eFactType.Birthday:
                    fact = generateBirthdayFact();
                    break;
                case eFactType.ProfilePicture:
                    fact = generateProfilePictureFact();
                    break;
                case eFactType.LikedPages:
                    fact = generateLikedPagesFact();
                    break;
                case eFactType.Groups:
                    fact = generateGroupsFact();
                    break;
                case eFactType.ZodiacSign:
                    fact = generateZodiacSignFact();
                    break;
                default:
                    fact = "Fact unavailable.";
                    break;
            }

            return fact;
        }

        private string generateFriendsFact()
        {
            return r_LoggedInUser.Friends.Count > 0
                ? $"You have {r_LoggedInUser.Friends.Count} friends!"
                : "You have no friends on Facebook.";
        }

        private string generatePostsFact()
        {
            return r_LoggedInUser.Posts.Count > 0
                ? $"You've made {r_LoggedInUser.Posts.Count} posts so far!"
                : "You haven't made any posts yet.";
        }

        private string generateAgeFact()
        {
            string fact;

            if (DateTime.TryParse(r_LoggedInUser.Birthday, out DateTime io_Birthdate))
            {
                int age = DateTime.Now.Year - io_Birthdate.Year;

                if (io_Birthdate.Date > DateTime.Now.AddYears(-age)) age--;
                fact = $"You are {age} years old!";
            }
            else
            {
                fact = "Unable to determine your age.";
            }

            return fact;
        }

        private string generateRelationshipStatusFact()
        {
            return $"Your relationship status is: {r_LoggedInUser.RelationshipStatus}.";
        }

        private string generateHometownFact()
        {
            return $"You live in {r_LoggedInUser.Hometown?.Name ?? "an unknown place"}!";
        }

        private string generateGenderFact()
        {
            return $"Your gender is: {r_LoggedInUser.Gender}.";
        }

        private string generateBirthdayFact()
        {
            return $"You were born on {r_LoggedInUser.Birthday}!";
        }

        private string generateProfilePictureFact()
        {
            return $"{r_LoggedInUser.Name}'s profile picture is:";
        }

        private string generateLikedPagesFact()
        {
            return $"You like {r_LoggedInUser.LikedPages.Count} pages.";
        }

        private string generateGroupsFact()
        {
            return $"You are a member of {r_LoggedInUser.Groups.Count} groups.";
        }

        private string generateZodiacSignFact()
        {
            string fact;

            if (DateTime.TryParse(r_LoggedInUser.Birthday, out DateTime io_Birthdate))
            {
                eZodiacSign zodiacSign = getZodiacSign(io_Birthdate);
                fact = $"Your zodiac sign is {zodiacSign}!";
            }
            else
            {
                fact = "Unable to determine your zodiac sign.";
            }

            return fact;
        }
    }
}

