using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using DataAccesLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntityFramework
{
    public class EfMessage2Repository:GenericRepository<Message2>,IMessage2Dal
    {
        public List<Message2> GetSendBoxWithMessageByWriter(int id)
        {
            using (Context c =new Context())
            {
                return c.message2s.Include(x => x.ReceiverUser).Where(y => y.senderID == id).ToList();
            }
        }

        public List<Message2> GetInboxWithMessageByWriter(int id)
        {
            using(var c = new Context())
            {
                return c.message2s.Include(x => x.UserSender).Where(x => x.ReceiverID == id).ToList();
            }
        }

       
    }
}
