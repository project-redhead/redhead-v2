using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectRedhead.Core.Domain;
using ProjectRedhead.Domain.UserAggregrate;

namespace ProjectRedhead.Application.Features.User.DataTransfer
{
    public class UserDto
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
    }
}
