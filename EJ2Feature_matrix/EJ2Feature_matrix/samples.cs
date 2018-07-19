using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.UpdatedNUnit.Framework;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using NUnit.Core.Extensions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Collections;
using EJ2Feature_matrix;

namespace EJ2Fature_matrix
{
    [TestFixture("Chrome")]
    [ImageComparison(true)]
    public class DatePicker : NUnitUtil
    {
        public DatePicker(string browser)
        {
            driver = GetWebDriverForBrowser(browser);
        }

        [TestFixtureTearDown]
        public void quitDriver()
        {
            driver.Quit();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_001_default()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y-15, 250, 340);
            driver.Navigate().Refresh();

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Disable")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_002_disable()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[6]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-disabled")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 250, 330);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-WeekNumber")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_003_weeknumber()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[14]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 360);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-RTL")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_004_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Readonly")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_005_readonly()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[8]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Rtl and Weeknumber")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_006_rtl_weeknumber()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[14]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 360);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-clearbutton")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_007_clearbutton()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-clearbutton-disable")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_008_clearbutton_disable()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[10]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-todaybtn")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_009_todaybtn()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[16]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-firstday")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_010_firstday()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='max']")).SendKeys("5");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-value")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_011_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/5/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-max")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_012_max()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/1/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-min")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_013_min()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("5/15/2018");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-min and max")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_014_min_max()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("5/25/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-minmax and value")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_015_min_max_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("5/25/2018");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/15/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-strictmode")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_016_strictMode_False()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("5/25/2018");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/26/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-strictmode")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_017_strictMode_true()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("5/25/2018");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/26/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[12]/ejs-checkbox")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-min_max_same")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_018_min_max_same()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/5/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-width")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_020_width()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='width']")).SendKeys("200px");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-width_in_number")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_021_width_in_Number()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='widthstring']")).SendKeys("200");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-placeholder")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_022_placeholder()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='placeholder']")).SendKeys("Select your Date of Birth");
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-show")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_022_show()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("6/5/2018");
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[43]/div/ejs-checkbox/label/span[1]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-hide")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_023_hide()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[43]/div/ejs-checkbox/label/span[1]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[43]/div/ejs-checkbox/label/span[1]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-focus")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_024_focus()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='focusIn']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-blur")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_025_blur()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='focusIn']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-start")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_026_start_year()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-strat")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_027_start_decade()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-strat")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_028_start_depth_Decade()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='depth']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='depth']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='depth']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-strat")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_029_start_depth_year()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='depth']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='depth']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-strat")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_030_start_depth_decade_year()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='depth']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='depth']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-format")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_031_dd_MMM_yy()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-format")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_032_yyy_MM_dd()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-format")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_033_dd_MMMM()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-float")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_034_float_auto()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowUp);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-float")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_035_float_auto_with_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowUp);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-float")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_036_float_always()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            //driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-float")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_037_float_always_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-value")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_038_outof_range_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2108");
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowUp);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-value")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_039_outof_range_value_popup()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowUp);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2108");
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[3]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-min_max")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_040_min_max()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("5/5/2017");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("4/5/2017");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-min_max")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_041_min_max_2()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("5/5/2017");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("6/5/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-min_max")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_042_min_max_3()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("5/5/2017");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("6/5/2018");
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[12]/ejs-checkbox")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-min_max")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_043_readonly_with_show()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[8]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[43]/div/ejs-checkbox/label/span[1]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1.50));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-min_max")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_044_rtl_with_float_always()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-min_max")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_045_rtl_with_float_auto()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowUp);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-min_max")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_046_rtl_with_float_never()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-min_max")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_047_value_with_float_never()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[1]")).Click();
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
           // driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).SendKeys(Keys.Tab);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-min_max")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_048_value_with_float_auto()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowUp);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            // driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).SendKeys(Keys.Tab);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-min_max")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_049_value_with_float_always()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            //driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).SendKeys(Keys.Tab);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }


        [Test, Description("TEST-15541: EJ2_FeatureMatrix-min_max")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_050_value_with_float_never()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[1]")).Click();
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            // driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).SendKeys(Keys.Tab);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-min_max")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_051_value_with_float_auto()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowUp);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            // driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).SendKeys(Keys.Tab);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-min_max")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_052_value_with_float_always()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            //driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).SendKeys(Keys.Tab);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-min_max")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_053_Min_high()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("4/4/2018");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/8/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-min_max")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_053_Min_high_strictmode()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("4/4/2018");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/8/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[12]/ejs-checkbox")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-placeholder")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_054_placeholder_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='placeholder']")).SendKeys("Select your Date of Birth");
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-placeholder")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_055_clearicon_auto()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowUp);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[10]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            // driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).SendKeys(Keys.Tab);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-placeholder")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_056_clearicon_always()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[10]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            // driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).SendKeys(Keys.Tab);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-placeholder")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_057_clearicon_never()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[10]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            // driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).SendKeys(Keys.Tab);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Disable")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_058_value_disable()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[6]/ejs-checkbox/label/span")).Click();
            //driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y-15, 250, 330);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Disable")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_059_rtl_disable()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[6]/ejs-checkbox/label/span")).Click();
            //driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 330);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-minmax and value")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_060_min_max_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("5/5/2017");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("5/25/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-minmax and value")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_061_min_max_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("5/5/9999");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("5/25/9999");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-minmax and value")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_062_min_max_start_decade()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/5/2017");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("9/25/2017");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-minmax and value")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_063_min_max_start_year()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/5/2017");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("9/25/2017");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-minmax and value")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_064_min_max__value_start_decade()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/5/2017");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("9/25/2017");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("7/18/2017");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-minmax and value")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_065_min_max_value_start_year()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/5/2017");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("9/25/2017");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("7/18/2017");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-minmax and value")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_066_min_max__value_start_decade_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/5/2017");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("9/25/2017");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("7/18/2017");
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-minmax and value")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_065_min_max_value_start_year_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/5/2017");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("9/25/2017");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("7/18/2017");
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-minmax and value")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_068_value_start_year_strict_false()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("7/18/9999");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-minmax and value")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_069_value_start_year_strict_true()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("7/18/9999");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[12]/ejs-checkbox")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-minmax and value")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_070_value_start_decade_strict_false()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("7/18/9999");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-minmax and value")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_071_value_start_decade_strict_true()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("7/18/9999");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[12]/ejs-checkbox")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-minmax and value")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_072_min_max()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/5/9999");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("9/25/9999");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-minmax and value")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_073_min_max_value_same()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("9/25/2018");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("9/25/2018");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("9/25/2018");
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[16]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-minmax and value")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_074_width_auto_value_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='widthstring']")).SendKeys("400");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowUp);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[3]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 410, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-minmax and value")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_075_width_auto_value_clear_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='widthstring']")).SendKeys("400");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowUp);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 410, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-format")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_076_dd_MMM_yy()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-format")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_076_decade_show()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/18/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[43]/div/ejs-checkbox/label/span[1]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-format")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_077_invalid_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("date");
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-format")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_078_invalid_value2()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("set value");
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-format")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_079_invalid_value_strictmode()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("13/13/2018");
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[12]/ejs-checkbox")).Click();
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-format")]
        [Category("EJ2_DatePicker")]
        [Category("Basic")]
        public void TEST_15541_080_rtl_todaybtn()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/date");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("1/13/2018");
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[16]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/date/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();
        }
    }


[TestFixture("Chrome")]
[ImageComparison(true)]
 public class DateRangePicker : NUnitUtil
{
    public DateRangePicker(string browser)
    {
        driver = GetWebDriverForBrowser(browser);
    }

    [TestFixtureTearDown]
    public void quitDriver()
    {
        driver.Quit();
    }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0001_default()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Enable Editing
            
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }

    }
}