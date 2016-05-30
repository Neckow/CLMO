using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colimo.Models
{
    public class MenuListData : List<MenuItem>
    {
        public MenuListData()
        {
            this.Add(new MenuItem()
            {
                Title = "Contracts",
                IconSource = "contracts.png",
                TargetType = typeof(ContractsPage)
            });

            this.Add(new MenuItem()
            {
                Title = "Leads",
                IconSource = "Lead.png",
                TargetType = typeof(LeadsPage)
            });

            this.Add(new MenuItem()
            {
                Title = "Accounts",
                IconSource = "Accounts.png",
                TargetType = typeof(AccountsPage)
            });

            this.Add(new MenuItem()
            {
                Title = "Opportunities",
                IconSource = "Opportunity.png",
                TargetType = typeof(OpportunitiesPage)
            });
        }
    }
}
