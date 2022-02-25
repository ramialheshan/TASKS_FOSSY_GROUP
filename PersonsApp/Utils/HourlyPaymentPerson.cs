using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsApp.Utils
{
    public class HourlyPaymentPerson : BasePerson
    {
        #region Constructors

        public HourlyPaymentPerson()
        {
            
        }

        #endregion Constructors

        #region Events

        #endregion Events

        #region Variables

        #endregion Variables

        #region Fields

        #endregion Fields

        #region Properties

        public decimal HourlyPayment { get; set; }

        #endregion Properties

        #region Methods

        public override decimal AverageMonthlySalary()
        {
            return 20.8m * 8 * HourlyPayment;
        }

        #endregion Methods

        #region EventHandlers

        #endregion EventHandlers
    }
}
