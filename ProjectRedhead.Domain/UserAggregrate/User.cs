using System;
using System.Collections.Generic;
using System.Text;
using ProjectRedhead.Core.Domain;

namespace ProjectRedhead.Domain.UserAggregrate
{
    /// <summary>
    /// Stellt ein Domain Model eines Nutzers dar.
    /// </summary>
    public class User : Entity
    {
        /// <summary>
        /// Der Nutzername des Nutzers.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Die Rolle des Nutzers.
        /// </summary>
        public UserRole Role { get; set; }

        /// <summary>
        /// Die erworbenen Punkte des Nutzers.
        /// </summary>
        public int Points { get; set; }


        public User(string displayName) : this(displayName, UserRole.Member, 100)
        {
        }

        public User(string displayName, UserRole role, int points)
        {
            DisplayName = displayName;
            Role = role;
            Points = points;
        }
    }
}
