using System;
using System.Collections.Generic;
using System.Text;

namespace OPP3
{
    class ApplyManager
    {
        public void Apply(CreditManager creditManager)
        {
            creditManager.Calculate();
        }

        public void CreditPreInfo(List<CreditManager> credits)
        {
            foreach (CreditManager item in credits)
            {
                item.Calculate();
            }
        }
    }
}
