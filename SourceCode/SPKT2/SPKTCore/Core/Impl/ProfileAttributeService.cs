using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPKTCore.Core.DataAccess;
using SPKTCore.Core.Domain;
using SPKTCore.Core.DataAccess.Impl;

namespace SPKTCore.Core.Impl
{
    public class ProfileAttributeService:IProfileAttributeService
    {
        private IProfileAttributeRepository profileAttributeRepository;
        public ProfileAttributeService()
        {
           // profileAttributeRepository = ObjectFactory.GetInstance<IProfileAttributeRepository>();  
            profileAttributeRepository=new ProfileAttributeRepository();
        }
        // lay ra list thuoc tinh cua ProfileID do
        public List<ProfileAttribute> GetProfileAttributesByProfileID(Int32 ProfileID)
        {
            List<ProfileAttribute> attributes = profileAttributeRepository.GetProfileAttributesByProfileID(ProfileID);
            //lay kieu thuoc tinh cua tung thuoc tinh
            foreach (ProfileAttribute attribute in attributes)
            {
                attribute.ProfileAttributeType =
                    profileAttributeRepository.GetProfileAttributeTypeByID(attribute.ProfileAttributeTypeID);
            }
            return attributes;
        }       
    }
    
}
