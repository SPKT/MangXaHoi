using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPKTCore.Core.DataAccess;
using SPKTCore.Core.Domain;

namespace SPKTCore.Core.DataAccess.Impl
{
    public class ProfileAttributeRepository:IProfileAttributeRepository
    {
        private Connection conn;
        public ProfileAttributeRepository()
        {
            conn = new Connection();
        }

        public ProfileAttributeType GetProfileAttributeTypeByID(Int32 profileAttributeTypeID)
        {
            ProfileAttributeType result;
            using (SPKTDataContext spktspktDC = conn.GetContext())
            {
                result = spktspktDC.ProfileAttributeTypes.Where(pat => pat.ProfileAttributeTypeID == profileAttributeTypeID).FirstOrDefault();
            }
            return result;
        }

        public List<ProfileAttributeType> GetProfileAttributeTypes()
        {
            List<ProfileAttributeType> result;
            using (SPKTDataContext spktspktDC = conn.GetContext())
            {
                IEnumerable<ProfileAttributeType> types = from t in spktspktDC.ProfileAttributeTypes
                                                          orderby t.SortOrder
                                                          select t;
                result = types.ToList();
            }

            return result;
        }

        public void AddProfileAttributes(params ProfileAttribute[] attributes)
        {
            foreach (ProfileAttribute attribute in attributes)
            {
                SaveProfileAttribute(attribute);
            }
        }

        public void SaveProfileAttribute(ProfileAttribute attribute)
        {
            using (SPKTDataContext spktDC = conn.GetContext())
            {
                if (attribute.ProfileAttributeID > 0)
                {
                    spktDC.ProfileAttributes.Attach(attribute, true);
                }
                else
                {
                    spktDC.ProfileAttributes.InsertOnSubmit(attribute);
                }
                spktDC.SubmitChanges();
            }
        }

        public List<ProfileAttribute> GetProfileAttributesByProfileID(Int32 ProfileID)
        {
            List<ProfileAttribute> list = new List<ProfileAttribute>();

            using (SPKTDataContext spktDC = conn.GetContext())
            {
                IEnumerable<ProfileAttribute> result = from pa in spktDC.ProfileAttributes
                                                       join pat in spktDC.ProfileAttributeTypes
                                                       on pa.ProfileAttributeTypeID equals pat.ProfileAttributeTypeID
                                                       orderby pat.SortOrder
                                                       where pa.ProfileID == ProfileID
                                                       select pa;
                list = result.ToList();
            }

            return list;
        }
    }
}
