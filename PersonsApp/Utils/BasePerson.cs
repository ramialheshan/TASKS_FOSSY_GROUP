using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PersonsApp.Utils
{
    [XmlInclude(typeof(FixedPaymentPerson))]
    [XmlInclude(typeof(HourlyPaymentPerson))]
    public abstract class BasePerson
    {
        #region Constructors

        #endregion Constructors

        #region Events

        #endregion Events

        #region Variables

        #endregion Variables

        #region Fields

        #endregion Fields

        #region Properties

        public int ID { get; set; }
        public string Name { get; set; }

        #endregion Properties

        #region Methods

        public abstract decimal AverageMonthlySalary();

        public override string ToString()
        {
            return string.Format("ID: {0} - Name: {1} - AverageMonthlySalary: {2}", ID, Name, AverageMonthlySalary());
        }

        #endregion Methods

        #region EventHandlers

        #endregion EventHandlers
    }
}

