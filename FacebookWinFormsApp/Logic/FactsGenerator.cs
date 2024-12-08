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
        private readonly List<eFactType> r_Facts;
        private int m_FactIndex;

        public FactsGenerator(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser ?? throw new ArgumentNullException(nameof(i_LoggedInUser));
            r_Facts = new List<eFactType>
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
                return r_Facts[m_FactIndex == 0 ? r_Facts.Count - 1 : m_FactIndex - 1];
            }
        }

        private eZodiacSign getZodiacSign(DateTime i_Birthdate)
        {
            int day = i_Birthdate.Day;
            eZodiacSign zodiacSign = eZodiacSign.Unknown;
            eMonths month = (eMonths)i_Birthdate.Month;

            switch (month)
            {
                case eMonths.January:
                    zodiacSign = day <= 19 ? eZodiacSign.Capricorn : eZodiacSign.Aquarius;
                    break;
                case eMonths.February:
                    zodiacSign = day <= 18 ? eZodiacSign.Aquarius : eZodiacSign.Pisces;
                    break;
                case eMonths.March:
                    zodiacSign = day <= 20 ? eZodiacSign.Pisces : eZodiacSign.Aries;
                    break;
                case eMonths.April:
                    zodiacSign = day <= 19 ? eZodiacSign.Aries : eZodiacSign.Taurus;
                    break;
                case eMonths.May:
                    zodiacSign = day <= 20 ? eZodiacSign.Taurus : eZodiacSign.Gemini;
                    break;
                case eMonths.June:
                    zodiacSign = day <= 20 ? eZodiacSign.Gemini : eZodiacSign.Cancer;
                    break;
                case eMonths.July:
                    zodiacSign = day <= 22 ? eZodiacSign.Cancer : eZodiacSign.Leo;
                    break;
                case eMonths.August:
                    zodiacSign = day <= 22 ? eZodiacSign.Leo : eZodiacSign.Virgo;
                    break;
                case eMonths.September:
                    zodiacSign = day <= 22 ? eZodiacSign.Virgo : eZodiacSign.Libra;
                    break;
                case eMonths.October:
                    zodiacSign = day <= 22 ? eZodiacSign.Libra : eZodiacSign.Scorpio;
                    break;
                case eMonths.November:
                    zodiacSign = day <= 21 ? eZodiacSign.Scorpio : eZodiacSign.Sagittarius;
                    break;
                case eMonths.December:
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

            if (m_FactIndex >= r_Facts.Count)
            {
                m_FactIndex = 0;
            }

            eFactType currentFact = r_Facts[m_FactIndex];
            string fact = getFact(currentFact);

            m_FactIndex++;

            return fact;
        }

        private string getFact(eFactType i_CurrentFact)
        {
            string fact = string.Empty;

            switch (i_CurrentFact)
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

