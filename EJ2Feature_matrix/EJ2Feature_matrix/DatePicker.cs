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

//namespace EJ2Feature_matrix
//{
//    [TestFixture("Chrome")]
//    [ImageComparison(true)]
//    public class DatePicker : NUnitUtil
//    {
//        public DatePicker(string browser)
//        {
//            driver = GetWebDriverForBrowser(browser);
//        }

//        [TestFixtureTearDown]
//        public void quitDriver()
//        {
//            driver.Quit();
//        }

//        [Test, TestCaseSource(typeof(Samples), "EJ2DatePicker")]
//        public void EJ2_DatePicker(string url, string datepickerId, string buttonId)
//        {
//            helper.buttonClick(driver, url, buttonId);
//            //IWebElement DatePicker = driver.FindElement(By.Id(datepickerId));
//            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
//            //Taking Screeshot
//            TakeAndCompareScreenshot(date.X, date.Y, 250, 300);

//        }

//        [Test, TestCaseSource(typeof(Samples), "EJ2DatePickerDisable")]
//        public void EJ2_DatePickerDisable(string url, string datepickerId, string buttonId)
//        {
//            helper.buttonClick1(driver, url, buttonId);
//            //IWebElement DatePicker = driver.FindElement(By.Id(datepickerId));
//            System.Drawing.Point date = driver.FindElement(By.ClassName("e-disabled")).Location;
//            //Taking Screeshot
//            TakeAndCompareScreenshot(date.X, date.Y, 250, 300);

//        }
//        [Test, TestCaseSource(typeof(Samples), "EJ2DatePickerWeekNumber")]
//        public void EJ2_DatePickerWeekNumber(string url, string datepickerId, string buttonId)
//        {
//            helper.buttonClick2(driver, url, buttonId);
//            //IWebElement DatePicker = driver.FindElement(By.Id(datepickerId));
//            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
//            //Taking Screeshot
//            TakeAndCompareScreenshot(date.X, date.Y, 250, 330);

//        }
//        [Test, TestCaseSource(typeof(Samples), "EJ2DatePickerRTL")]
//        public void EJ2_DatePickeRTL(string url, string datepickerId, string buttonId)
//        {
//            helper.buttonClick3(driver, url, buttonId);
//            //IWebElement DatePicker = driver.FindElement(By.Id(datepickerId));
//            System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
//            //Taking Screeshot
//            TakeAndCompareScreenshot(date.X, date.Y, 250, 300);

//        }
//        // [Test, Description("TEST-15541: EJ2_FeatureMatrix for default state")]
//        //// [Test, Description("EJ2_DatePicker: EJ2_FeatureMatrix for default state")]
//        // [Category("DatePicker")]
//        // public void TEST_15541_01(string url, string datepickerId, string buttonId)
//        // {
//        //     helper.buttonClick(driver, url, buttonId);
//        //     //IWebElement DatePicker = driver.FindElement(By.Id(datepickerId));
//        //     System.Drawing.Point date = driver.FindElement(By.ClassName("e-calendar")).Location;
//        //     //Taking Screeshot
//        //     TakeAndCompareScreenshot(date.X, date.Y, 250, 300);

//        // }

//        // [Test, Description("TEST-15541: EJ2_FeatureMatrix for disable state")]
//        // [Category("DatePicker")]
//        // public void TEST_15541_02(string url, string datepickerId, string buttonId)
//        // {
//        //     helper.buttonClick1(driver, url, buttonId);
//        //     //IWebElement DatePicker = driver.FindElement(By.Id(datepickerId));
//        //     System.Drawing.Point date = driver.FindElement(By.ClassName("e-disabled")).Location;
//        //     //Taking Screeshot
//        //     TakeAndCompareScreenshot(date.X, date.Y, 250, 300);

//        // }

//    }
//}
