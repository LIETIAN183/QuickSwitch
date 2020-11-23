using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using GalaSoft.MvvmLight;
using Microsoft.Win32;

namespace QuickSwitch.ViewModel
{
    public class MainViewModel:ViewModelBase
    {
        #region 构造函数
        public MainViewModel()
        {
            _queryText = "Hello";
            GetInstalledApps();
        }
        #endregion

        private string _queryText;
        public string QueryText
        {
            get {
                return _queryText; }
            set
            {
                _queryText = value;
                Trace.WriteLine(value.ToString());

                //Query();
            }
        }

        public List<object> GetInstalledApps()

        {
            List<object> result = new List<object>();
            string uninstallKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";

            using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(uninstallKey))

            {

                foreach (string skName in rk.GetSubKeyNames())

                {

                    using (RegistryKey sk = rk.OpenSubKey(skName))

                    {

                        try

                        {

                            result.Add(sk.GetValue("DisplayName"));
                            Trace.WriteLine(sk.GetValue("DisplayName"));

                        }

                        catch (Exception ex)

                        { }

                    }
                }
            }
            return result;
        }
    }
}
