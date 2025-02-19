using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.EntityLayer.Concrete
{
    public class AdminMessage
    {
        public int AdminMessageId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string O_Clock { get; set; }
    }
}
