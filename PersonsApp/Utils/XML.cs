using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PersonsApp.Utils
{
    public static class XML
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

        public static T Load<T>(FileInfo file)
            where T : class
        {
            if (!file.Exists) return null;

            try
            {
                using (var fileStream = File.OpenRead(file.FullName))
                {
                    var XmlSerializer = new XmlSerializer(typeof(T));
                    return XmlSerializer.Deserialize(fileStream) as T;
                }
            }
            catch (Exception)
            {
                
            }
          
            return null;
        }

        public static void Save<T>(FileInfo file, T value)
            where T : class
        {
            try
            {
                using (var fs = new System.IO.FileStream(file.FullName, System.IO.FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
                {
                    fs.SetLength(0);
                    XmlSerializer XmlSerializer = new XmlSerializer(typeof(T));
                    XmlSerializer.Serialize(fs, value);
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }


        #endregion Methods

        #region EventHandlers

        #endregion EventHandlers
    }
}
