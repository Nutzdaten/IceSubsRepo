using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IceSubs.Models
{
    public class MediaRepository
    {

        IceSubsContext m_db = new IceSubsContext();
        public IQueryable<Medium> GetAllMedia()
        {
            return m_db.Media; //TODO: implement database
        }
    }
}