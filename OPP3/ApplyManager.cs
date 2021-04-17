using System;
using System.Collections.Generic;
using System.Text;

namespace OPP3
{
    class ApplyManager
    {
        //Dependency Injection
        //Method Injection
        public void Apply(CreditManager creditManager, ILoggerService loggerService)
        {
            creditManager.Calculate();
            loggerService.Log();
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
