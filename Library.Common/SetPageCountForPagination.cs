using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Common
{
    public static class SetPageCountForPagination
    {

        public static int PageCount(int userCount, int take)
        {
            int PageCount = userCount / take;

            if (userCount % take != 0)
            {
                PageCount += 1;
            }

            return PageCount;
        }
    }
}
