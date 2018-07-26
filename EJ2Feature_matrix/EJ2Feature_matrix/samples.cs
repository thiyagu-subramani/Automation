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
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
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
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys(Keys.Enter);
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
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
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
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 330);
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
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
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
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
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
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
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
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
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
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
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
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
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
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
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
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
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
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
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
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
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
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
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
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
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
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(4.00));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

            //((IJavaScriptExecutor)driver).ExecuteScript("location.reload()");
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0002_disable()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[6]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0003_disable_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing

            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[6]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0004_disable_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[6]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            driver.Navigate().Refresh();

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0005_disable_value_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[6]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);


        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0006_disable_strat_end()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/13/2018");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("2/13/2018");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[6]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);


        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0007_disable_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[6]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            //driver.Get("//html");
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);


        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0008_clearbtn_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            //driver.Get("//html");
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_popup']/div[2]/button[1]")).Click();
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);


        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0009_clearbtn_value_disable()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[10]/ejs-checkbox/label/span")).Click();
            //driver.Get("//html");
            //driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[1]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_popup']/div[2]/button[1]")).Click();
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);


        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0010_clearbtn_clear_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_popup']/div[2]/button[1]")).Click();
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[1]")).Click();
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);


        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0011_clearbtn_clear_value_auto()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowUp);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[3]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_popup']/div[2]/button[1]")).Click();
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);


        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0012_clearbtn_value_auto()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowUp);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[3]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_popup']/div[2]/button[1]")).Click();
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            //driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0013_clearbtn_value_always()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[3]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_popup']/div[2]/button[1]")).Click();
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            //driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0014_clearbtn_claer_value_always()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[3]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_popup']/div[2]/button[1]")).Click();
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0015_clearbtn_value_never()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            //driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_popup']/div[2]/button[1]")).Click();
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[1]")).Click();
            //driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0016_clearbtn_claer_value_never()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            //driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_popup']/div[2]/button[1]")).Click();
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[1]")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0017_clearbtn_value_popup_auto()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowUp);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[3]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0018_clearbtn_claer_value_never()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            //driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0019_weeknumber_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[14]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 510, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0020_weeknumber_rtl_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[14]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[4]/ejs-checkbox/label/span ")).Click();
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 510, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0021_weeknumber_value_popup_auto()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowUp);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[14]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[3]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 510, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0022_weeknumber_value_popup_always()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[14]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[3]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 510, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0023_readonly_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[8]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0024_readonly()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[8]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0025_readonly_value_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[8]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0026_readonly_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[8]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.00));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0027_readonly_show()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[8]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[53]/div/ejs-checkbox/label/span[1]")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0028_readonly_focus_blur()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[8]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='focusIn']")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0029_readonly_icon_click()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[8]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0030_strictmode_false()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/9999");
            // driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0031_strictmode()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/9999");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0032_strictmode_popup()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/9999");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0033_strictmode()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/1111 - 5/13/2018");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0034_strictmode_popup()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/1111 - 5/13/2018");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0035_strictmode()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/1111 - 5/13/9999");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0036_strictmode_popup()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/1111 - 5/13/9999");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0037_strictmode_false_startdate()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/13/1111");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("1/13/2018");
            // driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0038_strictmode_false_enddate()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/13/2018");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("1/13/9999");
            // driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0039_strictmode_false_enddate()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/13/1111");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("1/13/9999");
            // driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0040_strictmode_enddate_startdate()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/13/1111");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("1/13/9999");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0040_strictmode_enddate_startdate_popup()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/13/1111");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("1/13/9999");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0041_strictmode_enddate()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/13/2018");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("1/13/9999");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0042_strictmode_enddate_popup()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/13/2018");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("1/13/9999");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0043_strictmode_startdate()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/13/1111");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("1/13/2018");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0044_strictmode_startdate_popup()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/13/1111");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("1/13/2018");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0045__format_dd_MMM_yy_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0046__format_dd_MMM_yy_start_end()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/13/2018");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("6/13/2018");
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0047_format_yyy_MM_dd_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0048_format_yyy_MM_dd_start_end()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/13/2018");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("6/13/2018");
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0049__format_dd_MMMM_HH_mm_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0050__format_dd_MMMM_HH_mm_start_end()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/13/2018");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("6/13/2018");
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0051__format_dd_MMMM_HH_mm_start_end_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/13/2018");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("6/13/2018");
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0052__format_dd_MMM_yy_value_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0053_format_yyy_MM_dd_start_end_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/13/2018");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("6/13/2018");
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0054_first_2()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='max']")).SendKeys("2");
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/13/2018");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("6/13/2018");
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0055_first_3()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='max']")).SendKeys("3");
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/13/2018");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("6/13/2018");
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0056_first_4()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='max']")).SendKeys("4");
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/13/2018");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("6/13/2018");
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0057_first_5()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='max']")).SendKeys("5");
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/13/2018");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("6/13/2018");
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0058_first_6()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='max']")).SendKeys("6");
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/13/2018");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("6/13/2018");
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0059_first_1()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='max']")).SendKeys("1");
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/13/2018");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("6/13/2018");
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0060_first_outofrange()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='max']")).SendKeys("8");
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/13/2018");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("6/13/2018");
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0061_first_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='max']")).SendKeys("1");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/13/2018");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("6/13/2018");
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0061_first_rtl_week()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='max']")).SendKeys("6");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[14]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/13/2018");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("6/13/2018");
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 510, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0062_max()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0063_max_value_outof()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0064_max_value_outof()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0065_max_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/4/2018");
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0066_max_value_outof_strict_popup()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();

            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0067_max_value_outof_strict()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }

        // finished

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0068_max_max()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='minValue']")).SendKeys("5/5/2018");
            //driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            //driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0069_max_max_float()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='minValue']")).SendKeys("5/5/2018");
            //driver.FindElement(By.XPath("//*[@id='valueObj']")).SendKeys("1/13/2018 - 5/13/2018");
            //driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0070_max_max_same()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='minValue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0071_min_max_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='minValue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("1/13/2018 - 5/13/2018");
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0072_min_max_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='minValue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/5/2018 - 5/5/2018");
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0073_min_max_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='minValue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/5/2018 - 6/5/2018");
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0074_min_max_value_strict()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='minValue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/5/2018 - 6/5/2018");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0075_min_max_value_strict()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='minValue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("4/5/2018 - 6/5/2018");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0076_min_max_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("5/5/2018");
            driver.FindElement(By.XPath("//*[@id='minValue']")).SendKeys("6/5/2018");
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }

        //// wrong output
        //[Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        //[Category("EJ2_DateRangePicker")]
        //[Category("Basic")]
        //public void TEST_15541_0077_min_max_startDate_as_range()
        //{
        //    driver.Navigate().GoToUrl("http://localhost:3000/#/");
        //    driver.Manage().Window.Maximize();
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        //    driver.FindElement(By.LinkText("DateRangePicker")).Click();
        //    Thread.Sleep(200);
        //    ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

        //    //Enable Editing
        //    driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("6/5/2018");
        //    driver.FindElement(By.XPath("//*[@id='minValue']")).SendKeys("5/5/2018");
        //    driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("5/6/2018");
        //    Thread.Sleep(TimeSpan.FromSeconds(2.50));
        //    driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
        //    driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
        //    Thread.Sleep(TimeSpan.FromSeconds(2.50));
        //    System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
        //    //  Taking Screeshot
        //    TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        //}
        //[Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        //[Category("EJ2_DateRangePicker")]
        //[Category("Basic")]
        //public void TEST_15541_0078_min_max_startDate_as_mindate()
        //{
        //    driver.Navigate().GoToUrl("http://localhost:3000/#/");
        //    driver.Manage().Window.Maximize();
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        //    driver.FindElement(By.LinkText("DateRangePicker")).Click();
        //    Thread.Sleep(200);
        //    ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
        //    //Enable Editing
        //    driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("6/5/2018");
        //    driver.FindElement(By.XPath("//*[@id='minValue']")).SendKeys("5/5/2018");
        //    driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("5/5/2018");
        //    Thread.Sleep(TimeSpan.FromSeconds(2.50));
        //    driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
        //    driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
        //    Thread.Sleep(TimeSpan.FromSeconds(2.50));
        //    System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
        //    //  Taking Screeshot
        //    TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        //}
        //[Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        //[Category("EJ2_DateRangePicker")]
        //[Category("Basic")]
        //public void TEST_15541_0079_min_max_enable()
        //{
        //    driver.Navigate().GoToUrl("http://localhost:3000/#/");
        //    driver.Manage().Window.Maximize();
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        //    driver.FindElement(By.LinkText("DateRangePicker")).Click();
        //    Thread.Sleep(200);
        //    ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

        //    //Enable Editing
        //    driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("5/5/2018");
        //    driver.FindElement(By.XPath("//*[@id='minValue']")).SendKeys("6/5/2018");
        //    Thread.Sleep(TimeSpan.FromSeconds(2.50));
        //    driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[6]/ejs-checkbox/label/span")).Click();
        //    driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[6]/ejs-checkbox/label/span")).Click();
        //    driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
        //    driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
        //    Thread.Sleep(TimeSpan.FromSeconds(2.50));
        //    System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
        //    //  Taking Screeshot
        //    TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        //}// wrong

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0080_min_max()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minValue']")).SendKeys("1/1/2018");
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("1/31/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0081_min_max_start_end()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minValue']")).SendKeys("1/1/2018");
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("1/31/2018");
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/1/2018");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("1/31/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0082_min_max()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minValue']")).SendKeys("1/1/2017");
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("1/31/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0083_min_max_start_end()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minValue']")).SendKeys("1/1/2017");
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("1/31/2018");
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("11/1/2017");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("1/31/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0084_min_max_start_end_outof()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minValue']")).SendKeys("1/1/2017");
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("1/31/2018");
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/1/2016");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("1/31/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }


        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0085_min_max_start_end_outof_strict()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minValue']")).SendKeys("1/5/2017");
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("1/31/2018");
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/5/2016");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("1/31/2018");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0086_min_max_start_end_outof_strict()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minValue']")).SendKeys("1/5/2017");
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("1/31/2018");
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/5/2016");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("1/31/2019");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0087_min_max_start_end_outof()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minValue']")).SendKeys("1/5/2017");
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("1/31/2018");
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/5/2016");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("1/31/2019");
            //driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0088_min_max_start_end_outof()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minValue']")).SendKeys("1/5/2017");
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("1/31/2018");
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/5/2016");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("5/31/2018");
            //driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0089_min_max_start_end_outof_strict()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minValue']")).SendKeys("1/5/2017");
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("1/31/2018");
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/5/2016");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("5/31/2018");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0090_min_max_start_end_same()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minValue']")).SendKeys("1/5/2017");
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("1/31/2018");
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("5/5/2017");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("5/5/2017");
            //driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }

        // Wrong Output

        //[Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        //[Category("EJ2_DateRangePicker")]
        //[Category("Basic")]
        //public void TEST_15541_0091_start_mindays()
        //{
        //    driver.Navigate().GoToUrl("http://localhost:3000/#/");
        //    driver.Manage().Window.Maximize();
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        //    driver.FindElement(By.LinkText("DateRangePicker")).Click();
        //    Thread.Sleep(200);
        //    ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
        //    //Enable Editing
        //    driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("5/5/2017");
        //    driver.FindElement(By.XPath("//*[@id='minday']")).SendKeys("5");
        //    //driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
        //    Thread.Sleep(TimeSpan.FromSeconds(2.50));
        //    driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
        //    driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
        //    Thread.Sleep(TimeSpan.FromSeconds(2.50));
        //    System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
        //    //  Taking Screeshot
        //    TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        //}

        //[Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        //[Category("EJ2_DateRangePicker")]
        //[Category("Basic")]
        //public void TEST_15541_0092_start_maxdays()
        //{
        //    driver.Navigate().GoToUrl("http://localhost:3000/#/");
        //    driver.Manage().Window.Maximize();
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        //    driver.FindElement(By.LinkText("DateRangePicker")).Click();
        //    Thread.Sleep(200);
        //    ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
        //    //Enable Editing
        //    driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("5/5/2017");
        //    driver.FindElement(By.XPath("//*[@id='maxday']")).SendKeys("5");
        //    //driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
        //    Thread.Sleep(TimeSpan.FromSeconds(2.50));
        //    driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
        //    driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
        //    Thread.Sleep(TimeSpan.FromSeconds(2.50));
        //    System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
        //    //  Taking Screeshot
        //    TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        //}


        //[Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        //[Category("EJ2_DateRangePicker")]
        //[Category("Basic")]
        //public void TEST_15541_0093_start_min_maxdays()
        //{
        //    driver.Navigate().GoToUrl("http://localhost:3000/#/");
        //    driver.Manage().Window.Maximize();
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        //    driver.FindElement(By.LinkText("DateRangePicker")).Click();
        //    Thread.Sleep(200);
        //    ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
        //    //Enable Editing
        //    driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("5/5/2017");
        //    driver.FindElement(By.XPath("//*[@id='minday']")).SendKeys("5");
        //    driver.FindElement(By.XPath("//*[@id='maxday']")).SendKeys("10");
        //    //driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
        //    Thread.Sleep(TimeSpan.FromSeconds(2.50));
        //    driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
        //    driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
        //    Thread.Sleep(TimeSpan.FromSeconds(2.50));
        //    System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
        //    //  Taking Screeshot
        //    TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        //}

        //[Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        //[Category("EJ2_DateRangePicker")]
        //[Category("Basic")]
        //public void TEST_15541_0094_start_min_maxdays()
        //{
        //    driver.Navigate().GoToUrl("http://localhost:3000/#/");
        //    driver.Manage().Window.Maximize();
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        //    driver.FindElement(By.LinkText("DateRangePicker")).Click();
        //    Thread.Sleep(200);
        //    ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
        //    //Enable Editing
        //    driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("5/5/2017");
        //    driver.FindElement(By.XPath("//*[@id='minday']")).SendKeys("2");
        //    driver.FindElement(By.XPath("//*[@id='maxday']")).SendKeys("5");
        //    //driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
        //    Thread.Sleep(TimeSpan.FromSeconds(2.50));
        //    driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
        //    driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
        //    Thread.Sleep(TimeSpan.FromSeconds(2.50));
        //    System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
        //    //  Taking Screeshot
        //    TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        //}
        //[Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        //[Category("EJ2_DateRangePicker")]
        //[Category("Basic")]
        //public void TEST_15541_0095_start_min_maxdays()
        //{
        //    driver.Navigate().GoToUrl("http://localhost:3000/#/");
        //    driver.Manage().Window.Maximize();
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        //    driver.FindElement(By.LinkText("DateRangePicker")).Click();
        //    Thread.Sleep(200);
        //    ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
        //    //Enable Editing
        //    driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("5/5/2017");
        //    driver.FindElement(By.XPath("//*[@id='minday']")).SendKeys("5");
        //    driver.FindElement(By.XPath("//*[@id='maxday']")).SendKeys("5");
        //    //driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
        //    Thread.Sleep(TimeSpan.FromSeconds(2.50));
        //    driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
        //    driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
        //    Thread.Sleep(TimeSpan.FromSeconds(2.50));
        //    System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
        //    //  Taking Screeshot
        //    TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        //}
        //[Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        //[Category("EJ2_DateRangePicker")]
        //[Category("Basic")]
        //public void TEST_15541_0096_start_min_maxdays()
        //{
        //    driver.Navigate().GoToUrl("http://localhost:3000/#/");
        //    driver.Manage().Window.Maximize();
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        //    driver.FindElement(By.LinkText("DateRangePicker")).Click();
        //    Thread.Sleep(200);
        //    ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
        //    //Enable Editing
        //    driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("5/5/2017");
        //    driver.FindElement(By.XPath("//*[@id='minday']")).SendKeys("2");
        //    driver.FindElement(By.XPath("//*[@id='maxday']")).SendKeys("2");
        //    //driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
        //    Thread.Sleep(TimeSpan.FromSeconds(2.50));
        //    driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
        //    driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
        //    Thread.Sleep(TimeSpan.FromSeconds(2.50));
        //    System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
        //    //  Taking Screeshot
        //    TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        //}
        //[Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        //[Category("EJ2_DateRangePicker")]
        //[Category("Basic")]
        //public void TEST_15541_0097_start_min_maxdays()
        //{
        //    driver.Navigate().GoToUrl("http://localhost:3000/#/");
        //    driver.Manage().Window.Maximize();
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        //    driver.FindElement(By.LinkText("DateRangePicker")).Click();
        //    Thread.Sleep(200);
        //    ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
        //    //Enable Editing
        //    driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("5/5/2017");
        //    driver.FindElement(By.XPath("//*[@id='minday']")).SendKeys("5");
        //    driver.FindElement(By.XPath("//*[@id='maxday']")).SendKeys("4");
        //    //driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
        //    Thread.Sleep(TimeSpan.FromSeconds(2.50));
        //    driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
        //    driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
        //    Thread.Sleep(TimeSpan.FromSeconds(2.50));
        //    System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
        //    //  Taking Screeshot
        //    TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        //}
        //[Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        //[Category("EJ2_DateRangePicker")]
        //[Category("Basic")]
        //public void TEST_15541_0098_start_min_maxdays()
        //{
        //    driver.Navigate().GoToUrl("http://localhost:3000/#/");
        //    driver.Manage().Window.Maximize();
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        //    driver.FindElement(By.LinkText("DateRangePicker")).Click();
        //    Thread.Sleep(200);
        //    ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
        //    //Enable Editing
        //    driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("5/11/2017");
        //    driver.FindElement(By.XPath("//*[@id='minday']")).SendKeys("35");
        //    driver.FindElement(By.XPath("//*[@id='maxday']")).SendKeys("45");
        //    //driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
        //    Thread.Sleep(TimeSpan.FromSeconds(2.50));
        //    driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
        //    driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
        //    Thread.Sleep(TimeSpan.FromSeconds(2.50));
        //    System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
        //    //  Taking Screeshot
        //    TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);
        //    driver.Navigate().Refresh();
        //} // we have to check this spec

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0099_startdate()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("5/11/2017");
            //driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0100_enddate()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minValue']")).SendKeys("1/1/2016");
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("6/6/2018");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("10/10/2017");
            //driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]
        public void TEST_15541_0101_same()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minValue']")).SendKeys("1/1/2016");
            driver.FindElement(By.XPath("//*[@id='maxValue']")).SendKeys("1/1/2016");
            driver.FindElement(By.XPath("//*[@id='endDate']")).SendKeys("1/1/2016");
            driver.FindElement(By.XPath("//*[@id='startdate']")).SendKeys("1/1/2016");
            //driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]

        public void TEST_15541_0102_width()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='widthstring']")).SendKeys("150");
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]

        public void TEST_15541_0103_width_popup()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='widthstring']")).SendKeys("150");
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("4/5/2018 - 6/5/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]

        public void TEST_15541_0104_width_popup_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='widthstring']")).SendKeys("150");
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("4/5/2018 - 6/5/2018");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]

        public void TEST_15541_0105_width_popup()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='widthstring']")).SendKeys("450");
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("4/5/2018 - 6/5/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]

        public void TEST_15541_0106_width_popup_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='widthstring']")).SendKeys("450");
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("4/5/2018 - 6/5/2018");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }


        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]

        public void TEST_15541_0107_width_string()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='width']")).SendKeys("250px");
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]

        public void TEST_15541_0108_width_string_popup()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='width']")).SendKeys("200px");
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("4/5/2018 - 6/5/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]

        public void TEST_15541_0109_width_string_popup_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='width']")).SendKeys("200px");
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("4/5/2018 - 6/5/2018");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]

        public void TEST_15541_0110_width_string_popup()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='width']")).SendKeys("500px");
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("4/5/2018 - 6/5/2018");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]

        public void TEST_15541_0111_width_string_popup_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='width']")).SendKeys("500px");
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("4/5/2018 - 6/5/2018");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]

        public void TEST_15541_0112_placeholder()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='placeholder']")).SendKeys("Select your booking range");
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]

        public void TEST_15541_0113_placeholder_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='placeholder']")).SendKeys("Select your booking range");
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[4]/ejs-checkbox/label/span ")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]

        public void TEST_15541_0113_placeholder_rtl_always()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='placeholder']")).SendKeys("Select your booking range");
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[4]/ejs-checkbox/label/span ")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]

        public void TEST_15541_0114_placeholder_always()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='placeholder']")).SendKeys("Select your booking range");
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]

        public void TEST_15541_0115_placeholder_auto()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='placeholder']")).SendKeys("Select your booking range");
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowUp);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]

        public void TEST_15541_0116_placeholder_rtl_auto()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='placeholder']")).SendKeys("Select your booking range");
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowUp);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[4]/ejs-checkbox/label/span ")).Click();
            driver.FindElement(By.XPath("//*[@id='daterangepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]

        public void TEST_15541_0117_placeholder()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='placeholder']")).SendKeys("Select your booking range within minDate and maxdate");
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]

        public void TEST_15541_0118_placeholder_always()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='placeholder']")).SendKeys("Select your booking range within minDate and maxdate");
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]

        public void TEST_15541_0119_show()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("4/4/2017 - 5/5/2018");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[53]/div/ejs-checkbox/label/span[1]")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 500, 420);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]

        public void TEST_15541_0120_hide()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("4/4/2017 - 5/5/2018");
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[53]/div/ejs-checkbox/label/span[1]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[53]/div/ejs-checkbox/label/span[1]")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]

        public void TEST_15541_0121_focus()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("4/4/2017 - 5/5/2018");
            driver.FindElement(By.XPath("//*[@id='focusIn']")).Click();
            // Thread.Sleep(TimeSpan.FromSeconds(2.50));
            //driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[53]/div/ejs-checkbox/label/span[1]")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]

        public void TEST_15541_0122_blur()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("4/4/2017 - 5/5/2018");
            driver.FindElement(By.XPath("//*[@id='focusIn']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            //driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[53]/div/ejs-checkbox/label/span[1]")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]

        public void TEST_15541_0123_readonly_focus()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[8]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("4/4/2017 - 5/5/2018");
            driver.FindElement(By.XPath("//*[@id='focusIn']")).Click();
            // Thread.Sleep(TimeSpan.FromSeconds(2.50));
            //driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[53]/div/ejs-checkbox/label/span[1]")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]

        public void TEST_15541_0124_disable_focus()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[6]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("4/4/2017 - 5/5/2018");
            driver.FindElement(By.XPath("//*[@id='focusIn']")).Click();
            // Thread.Sleep(TimeSpan.FromSeconds(2.50));
            //driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[53]/div/ejs-checkbox/label/span[1]")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateRangePicker")]
        [Category("Basic")]

        public void TEST_15541_0125_readonly_focus_show()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateRangePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[8]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("4/4/2017 - 5/5/2018");
            driver.FindElement(By.XPath("//*[@id='focusIn']")).Click();
            driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[53]/div/ejs-checkbox/label/span[1]")).Click();
            // Thread.Sleep(TimeSpan.FromSeconds(2.50));
            //driver.FindElement(By.XPath("/html/body/app/range/div[2]/div[53]/div/ejs-checkbox/label/span[1]")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-daterangepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
    }

    [TestFixture("Chrome")]
    [ImageComparison(true)]
    public class DateTimePicker : NUnitUtil
    {
        public DateTimePicker(string browser)
        {
            driver = GetWebDriverForBrowser(browser);

        }

        [TestFixtureTearDown]
        public void quitDriver()
        {
            driver.Quit();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1001_default()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(4.00));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            //Thread.Sleep(TimeSpan.FromSeconds(4.00));
            //driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[3]")).Click();
            //System.Drawing.Point time = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            ////  Taking Screeshot
            //TakeAndCompareScreenshot(time.X, time.Y - 15, 250, 340);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1002_disable()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing

            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[6]/ejs-checkbox/label/span")).Click();
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            //Thread.Sleep(TimeSpan.FromSeconds(4.00));
            //driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[3]")).Click();
            //System.Drawing.Point time = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            ////  Taking Screeshot
            //TakeAndCompareScreenshot(time.X, time.Y - 15, 250, 340);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1003_disable_with_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[6]/ejs-checkbox/label/span")).Click();
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            //Thread.Sleep(TimeSpan.FromSeconds(4.00));
            //driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[3]")).Click();
            //System.Drawing.Point time = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            ////  Taking Screeshot
            //TakeAndCompareScreenshot(time.X, time.Y - 15, 250, 340);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1004_disable_with_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[6]/ejs-checkbox/label/span")).Click();
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            //Thread.Sleep(TimeSpan.FromSeconds(4.00));
            //driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[3]")).Click();
            //System.Drawing.Point time = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            ////  Taking Screeshot
            //TakeAndCompareScreenshot(time.X, time.Y - 15, 250, 340);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1005_disable_with_rtl_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[6]/ejs-checkbox/label/span")).Click();
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            //Thread.Sleep(TimeSpan.FromSeconds(4.00));
            //driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[3]")).Click();
            //System.Drawing.Point time = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            ////  Taking Screeshot
            //TakeAndCompareScreenshot(time.X, time.Y - 15, 250, 340);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1006_disable_with_show()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            //driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[6]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[47]/div/ejs-checkbox/label/span[1]")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            //Thread.Sleep(TimeSpan.FromSeconds(4.00));
            //driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[3]")).Click();
            //System.Drawing.Point time = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            ////  Taking Screeshot
            //TakeAndCompareScreenshot(time.X, time.Y - 15, 250, 340);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1007_clearbtn_disable()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[10]/ejs-checkbox/label/span")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            //Thread.Sleep(TimeSpan.FromSeconds(4.00));
            //driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[3]")).Click();
            //System.Drawing.Point time = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            ////  Taking Screeshot
            //TakeAndCompareScreenshot(time.X, time.Y - 15, 250, 340);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1008_clearbtn_clear_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            // driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[10]/ejs-checkbox/label/span")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[1]")).Click();
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            //Thread.Sleep(TimeSpan.FromSeconds(4.00));
            //driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[3]")).Click();
            //System.Drawing.Point time = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            ////  Taking Screeshot
            //TakeAndCompareScreenshot(time.X, time.Y - 15, 250, 340);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1009_clearbtn_auto()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowUp);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
            //Thread.Sleep(TimeSpan.FromSeconds(4.00));
            //driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[3]")).Click();
            //System.Drawing.Point time = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            ////  Taking Screeshot
            //TakeAndCompareScreenshot(time.X, time.Y - 15, 250, 340);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1010_clearbtn_auto_focusout()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowUp);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1011_clearbtn_always()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1012_clearbtn_always_focusout()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1013_clearbtn_never()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[1]")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1014_clearbtn_never_focusout()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[1]")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1015_weeknumber()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[14]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1016_weeknumber_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[14]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1017_weeknumber_rtl_auto()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowUp);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[14]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1018_weeknumber_rtl_always()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[14]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1019_weeknumber_rtl_never()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[14]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[1]")).Click();
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1020_weeknumber_show()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[14]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[47]/div/ejs-checkbox/label/span[1]")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1021_readonly()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing

            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[8]/ejs-checkbox/label/span")).Click();

            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1022_readonly_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[8]/ejs-checkbox/label/span")).Click();

            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1023_readonly_value_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[8]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1024_readonly_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            //driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[8]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1025_readonly_show()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            //driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[8]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[47]/div/ejs-checkbox/label/span[1]")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1026_readonly_focusIn()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            //driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[8]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='focusIn'] ")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1027_readonly_icon_click()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            //driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[8]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='focusIn'] ")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1028_strictmode()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/9999 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1029_strictmode_true()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/9999 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1030_strictmode_popup()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/9999 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();

            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1031_strictmode_true_popup()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/9999 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1032_todaybtn()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[16]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1033_todaybtn_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[16]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click(); //rtl
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1034_todaybtn_rtl_weeknumber()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[16]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click(); //rtl
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[14]/ejs-checkbox/label/span")).Click(); // weeknumber
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1035_todaybtn_weeknumber()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[16]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[14]/ejs-checkbox/label/span")).Click(); // weeknumber
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1036_floatlabel_auto()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowUp);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1037_floatlabel_always()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1038_floatlabel_never()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1039_floatlabel_always()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1040_floatlabel_never_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1041_floatlabel_auto_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowUp);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1042_floatlabel_always_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1043_floatlabel_never_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1044_format_dd_MMM_yy_hh_mm_a()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.Enter);
            //driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();//rtl
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1045_format_yyyy_MM_dd_HH_MM()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.Enter);
            //driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();//rtl
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1046_format_dd_MMMM_HH_mm()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.Enter);
            //driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();//rtl
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1047_format_dd_MMM_yy_hh_mm_a_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();//rtl
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1048_format_yyyy_MM_dd_HH_MM_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();//rtl
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1049_format_dd_MMMM_HH_mm_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();//rtl
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1050_timeformat_hh_mm_a()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='timeformat']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='timeformat']/span")).SendKeys(Keys.Enter);
            //driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();//rtl
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[3]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1051_timeformat_HH_mm()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='timeformat']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='timeformat']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='timeformat']/span")).SendKeys(Keys.Enter);
            //driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();//rtl
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[3]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1052_timeformat_HH()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='timeformat']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='timeformat']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='timeformat']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='timeformat']/span")).SendKeys(Keys.Enter);
            //driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();//rtl
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[3]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1053_timeformat_format()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='timeformat']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='timeformat']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='timeformat']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='timeformat']/span")).SendKeys(Keys.Enter);
            //driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();//rtl
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[3]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1054_timeformat_format()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.Enter);

            driver.FindElement(By.XPath("//*[@id='timeformat']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='timeformat']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='timeformat']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='timeformat']/span")).SendKeys(Keys.Enter);
            //driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();//rtl
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[3]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1055_timeformat_format()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.Enter);

            driver.FindElement(By.XPath("//*[@id='timeformat']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='timeformat']/span")).SendKeys(Keys.Enter);
            //driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();//rtl
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[3]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1056_timeformat_format()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.Enter);

            driver.FindElement(By.XPath("//*[@id='timeformat']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='timeformat']/span")).SendKeys(Keys.Enter);
            //driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();//rtl
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[3]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1057_start_year()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.Enter);
            //driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();//rtl
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1058_start_decade()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.Enter);
            //driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();//rtl
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1059_start_depth()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.Enter);
            //driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();//rtl
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1060_start_depth()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.Enter);
            //driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();//rtl
            driver.FindElement(By.XPath("//*[@id='depth']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1061_start_depth()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.Enter);
            //driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();//rtl
            driver.FindElement(By.XPath("//*[@id='depth']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='depth']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1062_first_2()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='max']")).SendKeys("2");
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1063_first_3()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='max']")).SendKeys("3");
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1064_first_4()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='max']")).SendKeys("4");
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1065_first_5()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='max']")).SendKeys("5");
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1066_first_outof()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='max']")).SendKeys("8");
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1067_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/1111 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1068_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/9999 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1069_value_strict()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/1111 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1070_value_strict()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/9999 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1071_max()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            //driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1072_min()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            //driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/2/2027 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1073_min_max()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            //driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("2/22/2027 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1074_min_max_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/12/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("2/22/2027 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1074_min_max_value_same()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/12/2027");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/12/2027");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("2/12/2027");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1075_min_max_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("1/12/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("2/22/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1076_min_max_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("1/12/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("2/22/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1077_min_max_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("3/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("2/22/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1078_min_max_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("3/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("2/22/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1079_min_max_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("3/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("6/22/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1080_min_max_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("6/22/2026 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1081_step()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='step']")).SendKeys("60");
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[3]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1082_step()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='step']")).SendKeys("240");
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[3]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1083_width()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='width']")).SendKeys("400px");
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 400, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1084_width()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='width']")).SendKeys("400px");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 400, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1085_width()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            //driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='width']")).SendKeys("400px");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 400, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1086_width()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='widthstring']")).SendKeys("400");
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 400, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1087_width()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='widthstring']")).SendKeys("400");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 400, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1088_width()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            //driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='widthstring']")).SendKeys("400");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 400, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1089_width()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='widthstring']")).SendKeys("180");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 400, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1090_placeholder()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='placeholder']")).SendKeys("Select booking date and time");
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1091_placeholder()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='placeholder']")).SendKeys("Select booking date and time");
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='datetimepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1092_placeholder_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing

            driver.FindElement(By.XPath("//*[@id='placeholder']")).SendKeys("Select booking date and time");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1093_show()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[47]/div/ejs-checkbox/label/span[1]")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1094_show_hide()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[47]/div/ejs-checkbox/label/span[1]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[47]/div/ejs-checkbox/label/span[1]")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1095_focus()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='focusIn']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1096_blur()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='datetimepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1097_readonly_focus()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[8]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='focusIn']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_1098_readonly_focus_show()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/range");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("DateTimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[8]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='focusIn']")).Click();
            driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[47]/div/ejs-checkbox/label/span[1]")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-datetimepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y - 15, 250, 340);

        }
    }
    // TimePicker Component
    [TestFixture("Chrome")]
    [ImageComparison(true)]
    public class TimePicker : NUnitUtil
    {
        public TimePicker(string browser)
        {
            driver = GetWebDriverForBrowser(browser);

        }

        [TestFixtureTearDown]
        public void quitDriver()
        {
            driver.Quit();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00001_default()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00002_disable()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing

            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[6]/ejs-checkbox/label/span")).Click();
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00003_disable_with_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[6]/ejs-checkbox/label/span")).Click();//disble
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00004_disable_with_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[6]/ejs-checkbox/label/span")).Click();
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00005_disable_with_rtl_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[6]/ejs-checkbox/label/span")).Click();
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00006_disable_with_show()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            //driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[6]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[37]/div/ejs-checkbox/label/span[1]")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }



        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00007_clearbtn_disable()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[10]/ejs-checkbox/label/span")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00008_clearbtn_clear_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            // driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[10]/ejs-checkbox/label/span")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='timepicker']/span/span[1]")).Click();
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00009_clearbtn_auto()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowUp);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='timepicker']/span/span[2]")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00010_clearbtn_auto_focusout()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowUp);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='timepicker']/span/span[2]")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00011_clearbtn_always()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='timepicker']/span/span[2]")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00012_clearbtn_always_focusout()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='timepicker']/span/span[2]")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00013_clearbtn_never()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='timepicker']/span/span[1]")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00014_clearbtn_never_focusout()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='timepicker']/span/span[1]")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }

        //Readonly

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00015_readonly()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing

            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[8]/ejs-checkbox/label/span")).Click();

            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00016_readonly_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[8]/ejs-checkbox/label/span")).Click();

            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00017_readonly_value_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[8]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00018_readonly_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            //driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[8]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00019_readonly_show()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            //driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[8]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[37]/div/ejs-checkbox/label/span[1]")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00020_readonly_focusIn()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            //driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[8]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='focusIn'] ")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00021_readonly_icon_click()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            //driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[8]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='focusIn'] ")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='timepicker']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1.00));
            driver.FindElement(By.XPath("//*[@id='timepicker']/span/span[2]")).Click();
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }

        // floatlabel

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00022_floatlabel_auto()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowUp);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00023_floatlabel_always()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00024_floatlabel_never()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00025_floatlabel_always()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00026_floatlabel_never_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_00027_floatlabel_auto_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowUp);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00028_floatlabel_always_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='float']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00029_floatlabel_never_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        // format 

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00030_timeformat_hh_mm_a()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.Enter);
            //driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();//rtl
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00031_timeformat_HH_mm()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.Enter);
            //driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();//rtl
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00032_timeformat_HH()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='format']/span")).SendKeys(Keys.Enter);
            //driver.FindElement(By.XPath("/html/body/app/home/div[2]/div[4]/ejs-checkbox/label/span")).Click();//rtl
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        // value 

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00033_max()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("2/2/2017 2:30 AM");
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00034_min()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/2/2027 2:30 AM");
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00035_min_max()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            //driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/2/2027 4:00 AM");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("2/22/2027 7:00 AM");
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00036_min_max_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/12/2027 6:00 AM");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/2/2027 4:00 AM");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("2/12/2027 4:00 PM");
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00037_min_max_value_same()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/12/2027 4:00 AM");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/12/2027 4:00 AM");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("2/12/2027 4:00 AM");
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00038_min_max_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2027 3:00 AM");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/2/2027 4:00 AM");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("2/2/2027 7:00 AM");
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_00039_min_max_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2027 3:00 AM");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/2/2027 4:00 AM");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("2/2/2027 7:00 AM");
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00040_min_max_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2027 7:00 PM");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/2/2027 4:00 AM");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("2/2/2027 7:00 AM");
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            //driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_DateTimePicker")]
        [Category("Basic")]
        public void TEST_15541_00041_min_max_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2027 7:00 PM");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/2/2027 4:00 AM");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("2/2/2027 7:00 AM");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[12]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00042_min_max_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2027 5:00 AM");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/2/2027 4:00 AM");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("2/2/2027 7:00 AM");
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00043_min_max_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("5/2/2027 11:00 AM");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        } // step

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00044_step()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='step']")).SendKeys("60");
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00045_step()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='step']")).SendKeys("240");
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }// width

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00046_width()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='width']")).SendKeys("400px");
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 420, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00047_width()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='width']")).SendKeys("400px");
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 420, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00048_width()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            //driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='width']")).SendKeys("400px");
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 420, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00049_width()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='widthstring']")).SendKeys("400");
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 420, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00050_width()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='widthstring']")).SendKeys("400");
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 420, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00051_width()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            //driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='widthstring']")).SendKeys("400");
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 420, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00052_width()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='widthstring']")).SendKeys("200");
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 420, 290);

        }

        //placeholder
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00053_placeholder()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='placeholder']")).SendKeys("Select a booking  time");
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00054_placeholder()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='placeholder']")).SendKeys("Select booking  time");
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='timepicker']/span/span[2]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00055_placeholder_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing

            driver.FindElement(By.XPath("//*[@id='placeholder']")).SendKeys("Select a booking  time");
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[4]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }

        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00056_show()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[37]/div/ejs-checkbox/label/span[1]")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00057_show_hide()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[37]/div/ejs-checkbox/label/span[1]")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[37]/div/ejs-checkbox/label/span[1]")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00058_focus()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='focusIn']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00059_blur()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("//*[@id='timepicker_input']")).Click();
            driver.FindElement(By.XPath("//*[@id='focusOut']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00060_readonly_focus()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[8]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='focusIn']")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_TimePicker")]
        [Category("Basic")]
        public void TEST_15541_00062_readonly_focus_show()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("TimePicker")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("5/2/2027 10:00 AM");
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[8]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("//*[@id='focusIn']")).Click();
            driver.FindElement(By.XPath("/html/body/app/time/div[2]/div[37]/div/ejs-checkbox/label/span[1]")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            System.Drawing.Point time = driver.FindElement(By.ClassName("e-timepicker")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(time.X, time.Y - 15, 210, 290);

        }
    }
    [TestFixture("Chrome")]
    [ImageComparison(true)]
    public class Calendar : NUnitUtil
    {
        public Calendar(string browser)
        {
            driver = GetWebDriverForBrowser(browser);

        }

        [TestFixtureTearDown]
        public void quitDriver()
        {
            driver.Quit();
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2001_default()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 250, 340);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2002_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017");
            driver.FindElement(By.XPath("/html/body/app/calendar/div[2]/div[2]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 250, 310);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2003_weeknumber()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017");
            driver.FindElement(By.XPath("/html/body/app/calendar/div[2]/div[6]/ejs-checkbox/label")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 270, 310);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2004_weeknumber_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017");
            driver.FindElement(By.XPath("/html/body/app/calendar/div[2]/div[6]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/calendar/div[2]/div[2]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 270, 310);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2005_todaybtn()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017");
            driver.FindElement(By.XPath("/html/body/app/calendar/div[2]/div[8]/ejs-checkbox/label/span")).Click();//today
           // driver.FindElement(By.XPath("/html/body/app/calendar/div[2]/div[2]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 250, 310);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2006_todaybtn_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017");
            driver.FindElement(By.XPath("/html/body/app/calendar/div[2]/div[8]/ejs-checkbox/label/span")).Click();//today
            driver.FindElement(By.XPath("/html/body/app/calendar/div[2]/div[2]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 250, 310);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2007_todaybtn_weeknumber()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017");
            driver.FindElement(By.XPath("/html/body/app/calendar/div[2]/div[8]/ejs-checkbox/label/span")).Click();//today
            driver.FindElement(By.XPath("/html/body/app/calendar/div[2]/div[6]/ejs-checkbox/label")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 270, 310);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2008_firstday()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017");
            driver.FindElement(By.XPath("//*[@id='max']")).SendKeys("3");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 250, 310);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2009_firstday()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017");
            driver.FindElement(By.XPath("//*[@id='max']")).SendKeys("5");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 250, 310);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2010_firstday_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017");
            driver.FindElement(By.XPath("//*[@id='max']")).SendKeys("5");
            driver.FindElement(By.XPath("/html/body/app/calendar/div[2]/div[2]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 250, 310);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2010_today_rtl_weekunumber()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017");
            driver.FindElement(By.XPath("/html/body/app/calendar/div[2]/div[8]/ejs-checkbox/label/span")).Click();//today
            driver.FindElement(By.XPath("/html/body/app/calendar/div[2]/div[6]/ejs-checkbox/label")).Click();
            driver.FindElement(By.XPath("/html/body/app/calendar/div[2]/div[2]/ejs-checkbox/label/span")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 270, 310);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2011_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/2017");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 250, 300);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2012_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/9999");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 250, 300);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2013_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/2/1111");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 250, 300);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2014_min_max()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("2/2/2017");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("1/1/2016");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 250, 300);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2015_min_max()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("2/25/2017");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("1/1/2016");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 250, 300);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2016_min_max()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("2/25/2017");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/5/2017");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 250, 300);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2017_min_max()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("2/5/2017");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/25/2017");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 250, 300);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2018_min_max_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("2/25/2017");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/5/2017");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/15/2017");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 250, 300);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2019_min_max_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("2/25/2017");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/5/2017");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("1/15/2017");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 250, 300);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2020_min_max_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("2/25/2017");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/5/2017");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("3/15/2017");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 250, 300);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2021_min_max_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("2/25/2057");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/5/2017");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("7/15/2017");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 250, 340);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2022_min_max()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("2/25/2057");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/25/2057");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 250, 340);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2023_min_max_value()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys("2/25/2057");
            driver.FindElement(By.XPath("//*[@id='minvalue']")).SendKeys("2/25/2057");
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/25/2057");
            driver.FindElement(By.XPath("//*[@id='maxvalue']")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 250, 340);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2024_start_depth()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/25/2057");
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 250, 340);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2025_start_depth_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/25/2057");
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("/html/body/app/calendar/div[2]/div[2]/ejs-checkbox/label/span")).Click();
            //driver.FindElement(By.XPath("/html/body/app/calendar/div[2]/div[8]/ejs-checkbox/label/span")).Click(); //today
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 250, 340);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2026_start_depth_today()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/25/2057");
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.Enter);
            //driver.FindElement(By.XPath("/html/body/app/calendar/div[2]/div[2]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/calendar/div[2]/div[8]/ejs-checkbox/label/span")).Click(); //today
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 250, 340);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2027_start_depth_rtl_today()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/25/2057");
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("/html/body/app/calendar/div[2]/div[2]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/calendar/div[2]/div[8]/ejs-checkbox/label/span")).Click(); //today
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 250, 340);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2028_start_depth()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/25/2057");
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 250, 340);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2029_start_depth_rtl()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/25/2057");
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("/html/body/app/calendar/div[2]/div[2]/ejs-checkbox/label/span")).Click();
            //driver.FindElement(By.XPath("/html/body/app/calendar/div[2]/div[8]/ejs-checkbox/label/span")).Click(); //today
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 250, 340);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2030_start_depth_today()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/25/2057");
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.Enter);
            //driver.FindElement(By.XPath("/html/body/app/calendar/div[2]/div[2]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/calendar/div[2]/div[8]/ejs-checkbox/label/span")).Click(); //today
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 250, 340);
        }
        [Test, Description("TEST-15541: EJ2_FeatureMatrix-Default")]
        [Category("EJ2_Calendar")]
        [Category("Basic")]
        public void TEST_15541_2031_start_depth_rtl_today()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/#/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Calendar")).Click();
            Thread.Sleep(200);
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0, -250);");

            //Enable Editing
            driver.FindElement(By.XPath("//*[@id='value']")).SendKeys("2/25/2057");
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("//*[@id='start']/span")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("/html/body/app/calendar/div[2]/div[2]/ejs-checkbox/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/app/calendar/div[2]/div[8]/ejs-checkbox/label/span")).Click(); //today
            Thread.Sleep(TimeSpan.FromSeconds(2.50));
            // helper.buttonClick(driver, By.XPath("//*[@id='timepicker']/span/span[2]"));
            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
            //  Taking Screeshot
            TakeAndCompareScreenshot(date.X, date.Y, 250, 340);
        }
    }
}