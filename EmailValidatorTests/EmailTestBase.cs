using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailValidatorTests
{
    public class EmailTestBase
    {

        public TestContext TestContext { get; set; }





        public T GetTestSetting<T>(string name, T defaultvalue)
        {
            T returnValue = defaultvalue;

            try
            {
                var temp = TestContext.Properties[name];
                if (temp != null)
                {
                    returnValue = (T)Convert.ChangeType(temp, typeof(T));
                }

            }

            catch
            {
                //ignore
            }
            return returnValue;
        }
    }
}
