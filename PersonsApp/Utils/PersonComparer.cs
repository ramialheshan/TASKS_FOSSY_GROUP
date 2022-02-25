using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsApp.Utils
{
    public class PersonComparer : IComparer<BasePerson>
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

        #endregion Properties

        #region Methods

        public int Compare(BasePerson x, BasePerson y)
        {
            if (x.AverageMonthlySalary() == y.AverageMonthlySalary()) return x.Name.CompareTo(y.Name);
            else return x.AverageMonthlySalary().CompareTo(y.AverageMonthlySalary());
        }

        #endregion Methods

        #region EventHandlers

        #endregion EventHandlers

    }
}
