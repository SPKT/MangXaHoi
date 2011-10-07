using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPKTCore.Core.Domain
{
    public partial class Profile
    {
        public List<ProfileAttribute> Attributes { get; set; }
        public LevelOfExperience LevelOfExperienceType { get; set; }
    }
}
