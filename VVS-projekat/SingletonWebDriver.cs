using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVS_projekat
{
    public class SingletonWebDriver
    {
        private static IWebDriver instanca = new ChromeDriver();
        private SingletonWebDriver() { }
        public static IWebDriver Instance { get { return instanca; } }
    }
}

