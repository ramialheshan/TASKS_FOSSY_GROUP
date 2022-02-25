using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsApp.Utils
{
    public class PersonsSettings
    {
        #region Constructors

        public PersonsSettings()
        {
            Persons = new List<BasePerson>();
        }

        #endregion Constructors

        #region Events

        #endregion Events

        #region Variables

        #endregion Variables

        #region Fields

        #endregion Fields

        #region Properties

        public List<BasePerson> Persons { get; set; }

        #endregion Properties

        #region Methods

        internal void AddPerson(BasePerson person)
        {
            person.ID = Persons.Count == 0 ? 1 : Persons.Count + 1;
            Persons.Add(person);
        }

        #endregion Methods

        #region EventHandlers

        #endregion EventHandlers
    }
}
