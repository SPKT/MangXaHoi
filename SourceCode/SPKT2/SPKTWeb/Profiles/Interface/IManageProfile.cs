using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SPKTCore.Core.Domain;

namespace SPKTWeb.Profiles.Interface
{
    public interface IManageProfile
    {
        void ShowMessage(string Message);
        void LoadLevelOfExperienceTypes(List<LevelOfExperience> types);
        void loadProfileAttribute(List<ProfileAttributeType> profileAttributeType,Profile profile);
        void LoadProfile(Profile profile);
        void ShowProfileName(string profileName);
    }
}