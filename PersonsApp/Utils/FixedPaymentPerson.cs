using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsApp.Utils
{
    public class FixedPaymentPerson : BasePerson
    {
        #region Constructors

        public FixedPaymentPerson()
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

        public decimal FixedPayment { get; set; }

        #endregion Properties

        #region Methods

        public override decimal AverageMonthlySalary()
        {
            return FixedPayment;
        }

        #endregion Methods

        #region EventHandlers

        #endregion EventHandlers


    }
}
