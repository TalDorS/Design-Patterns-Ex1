using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Logic
{
    public class RandomFactGenerator
    {
        public enum FactType
        {
            Friends,
            Posts,
            Age,
            RelationshipStatus,
            Hometown,
            Gender,
            Birthday
        }

        private readonly User r_LoggedInUser;
        private readonly List<FactType> m_Facts;
        private int m_FactIndex;

        public RandomFactGenerator(User i_LoggedInUser)
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
                FactType.Birthday
            };
            m_FactIndex = 0;
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
                    fact = $"You have {r_LoggedInUser.Friends.Count} friends!";
                    break;
                case FactType.Posts:
                    fact = $"You've made {r_LoggedInUser.Posts.Count} posts so far!";
                    break;
                case FactType.Age:
                    if (DateTime.TryParse(r_LoggedInUser.Birthday, out DateTime birthday))
                    {
                        int age = DateTime.Now.Year - birthday.Year;
                        if (birthday.Date > DateTime.Now.AddYears(-age)) age--;
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
            }

            m_FactIndex++;

            return fact;
        }
    }
}

