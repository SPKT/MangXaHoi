using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPKTCore.Core.Domain;

namespace SPKTCore.Core.DataAccess.Impl
{
    public class PrivacyRepository:IPrivacyRepository
    {
        private Connection conn;
        public PrivacyRepository()
        {
            conn = new Connection();
        }
        //TODO: sua ProfileAttribute thay cho PrivacyFlagType
        public List<Domain.ProfileAttributeType> GetProfileAttributeType()
        {
            throw new NotImplementedException();
        }

        public List<VisibilityLevel> GetVisibilityLevels()
        {
            List<VisibilityLevel> result = new List<VisibilityLevel>();
            using (SPKTDataContext spktspktDC = conn.GetContext())
            {
                IEnumerable<VisibilityLevel> query = spktspktDC.VisibilityLevels;
                result = query.ToList();
            }
            return result;
        }

        public List<PrivacyFlag> GetPrivacyFlagsByProfileID(Int32 ProfileID)
        {
            List<PrivacyFlag> result = new List<PrivacyFlag>();
            using (SPKTDataContext spktDC = conn.GetContext())
            {
                IEnumerable<PrivacyFlag> query = spktDC.PrivacyFlags.Where(pf => pf.ProfileID == ProfileID);
                result = query.ToList();
            }
            return result;
        }

        public void SavePrivacyFlag(PrivacyFlag privacyFlag)
        {
            using (SPKTDataContext spktDC = conn.GetContext())
            {
                if (privacyFlag.PrivacyFlagID > 0)
                {
                    spktDC.PrivacyFlags.Attach(privacyFlag, true);
                }
                else
                {
                    spktDC.PrivacyFlags.InsertOnSubmit(privacyFlag);
                }
                spktDC.SubmitChanges();
            }
        }
    }
}
