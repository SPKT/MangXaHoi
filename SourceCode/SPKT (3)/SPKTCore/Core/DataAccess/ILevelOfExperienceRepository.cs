using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPKTCore.Core.Domain;

namespace SPKTCore.Core.DataAccess
{
    public interface ILevelOfExperienceRepository
    {
        List<LevelOfExperience> GetAllLevelOfExperienceTypes();
        LevelOfExperience GetLevelOfExperienceTypeByID(int LevelOfExperienceID);
        void SaveLevelOfExperienceType(LevelOfExperience levelOfExperience);
        void DeleteLevelOfExperienceType(LevelOfExperience levelOfExperience);
    }
}
