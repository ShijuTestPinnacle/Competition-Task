using AutoItX3Lib;
using MarsFramework.Global;
using MarsFramework.utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using static MarsFramework.Global.GlobalDefinitions;

namespace MarsFramework.Pages
{
    internal class ShareSkill
    {

        /* public ShareSkill()
         {
             PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
         }

         //Click on ShareSkill Button
         [FindsBy(How = How.LinkText, Using = "Share Skill")]
         private IWebElement ShareSkillButton{ get; set; }

         //Enter the Title in textbox
         [FindsBy(How = How.Name, Using = "title")]
         private IWebElement Title;

         //Enter the Description in textbox
         [FindsBy(How = How.Name, Using = "description")]
         private IWebElement Description;

         //Click on Category Dropdown
         [FindsBy(How = How.Name, Using = "categoryId")]
         private IWebElement CategoryDropDown;

         //Click on SubCategory Dropdown
         [FindsBy(How = How.Name, Using = "subcategoryId")]
         private IWebElement SubCategoryDropDown;

         //Enter Tag names in textbox
         [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")]
         private IWebElement Tags;

         //Select the Service type
         [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input")]
         private IWebElement ServiceTypeOptions;

         //Select the Location Type
         [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input")]
         private IWebElement LocationTypeOption;

         //Click on Start Date dropdown
         [FindsBy(How = How.Name, Using = "startDate")]
         private IWebElement StartDateDropDown;

         //Click on End Date dropdown
         [FindsBy(How = How.Name, Using = "endDate")]
         private IWebElement EndDateDropDown;

         //Storing the table of available days
         [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]")]
         private IWebElement Days;

         //Storing the starttime
         [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
         private IWebElement StartTime;

         //Click on StartTime dropdown
         [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
         private IWebElement StartTimeDropDown;

         //Click on EndTime dropdown
         [FindsBy(How = How.XPath, Using = "//div[3]/div[3]/input[1]")]
         private IWebElement EndTimeDropDown;

         //Click on Skill Trade option
         [FindsBy(How = How.XPath, Using = "//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']")]
         private IWebElement SkillTradeOption;

         //Enter Skill Exchange
         [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
         private IWebElement SkillExchange;

         //Enter the amount for Credit
         [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
         private IWebElement CreditAmount;

         //Click on Active/Hidden option
         [FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
         private IWebElement ActiveOption;

         //Click on Save button
         [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
         private IWebElement Save;
         */
   
        IWebElement ShareSkillButton => Base.driver.FindElement(By.XPath(".//*[@class='ui basic green button']"));
        IWebElement Title => Base.driver.FindElement(By.Name("title"));
        IWebElement Description => Base.driver.FindElement(By.Name("description"));
        IWebElement CategoryDropDown => Base.driver.FindElement(By.Name("categoryId"));
        IWebElement SubCategoryDropDown => Base.driver.FindElement(By.Name("subcategoryId"));
        IWebElement Tags => Base.driver.FindElement(By.XPath("//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]"));
        IWebElement ServiceTypeOptions => Base.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));
        IWebElement LocationTypeOption => Base.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));
        IWebElement StartDateDropDown => Base.driver.FindElement(By.Name("startDate"));
        IWebElement EndDateDropDown  => Base.driver.FindElement(By.Name("endDate"));
        //Mondaycheckbox
        IWebElement chekbox1 => Base.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input"));
        //Mondaystart time
        IWebElement Firststarttime => Base.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input"));
        //Monday End time
        IWebElement Firstendtime => Base.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div[1]/div[3]/div[3]/input"));
        //Tuesday checkbox
        IWebElement checkbox2 => Base.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[1]/div/input"));
        //Tuesday start time
        IWebElement secondstarttime => Base.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[2]/input"));
        // Tuesday end time
        IWebElement secondendtime => Base.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[3]/input"));
        //skill exchange checkbox
        IWebElement skillexchange => Base.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input"));
        //skill exchange tag
        IWebElement skillexchangetag => Base.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
        //credit checkbox
        IWebElement credit => Base.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input"));
        //credit amount
        IWebElement creditamount => Base.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/input"));
        //Fileupload click button
        IWebElement clickfileupload => Base.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));
        //Active checkbox
        IWebElement active => Base.driver.FindElement(By.Name("isActive"));
        //save button
        IWebElement save => Base.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]"));
        internal void clickshareskill()
        {
            Wait.ElementVisible(Base.driver, ".//*[@class='ui basic green button']", "XPath");

            ShareSkillButton.Click();
        }
        internal void EnterShareSkill(string skilltrade)
        {

            
          
            //Wait.ElementVisible(Base.driver, "Title", "ClassName");
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "shareskill");
            
            Title.Clear();
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
            Description.Clear();
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
            //choose category from dropdown
            CategoryDropDown.Click();
           SelectElement selectcategory = new SelectElement(CategoryDropDown);
           selectcategory.SelectByText("Programming & Tech");
            SubCategoryDropDown.Click();
            SelectElement selectsubcategory = new SelectElement(SubCategoryDropDown);
            selectsubcategory.SelectByText("QA");
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Firsttag"));
            Tags.SendKeys(Keys.Return);
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Secondtag"));
            ServiceTypeOptions.Click();
            LocationTypeOption.Click();
            StartDateDropDown.Click();
            // StartDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "start date"));
            //EndDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "End date"));
            StartDateDropDown.SendKeys("01112019");
            EndDateDropDown.SendKeys("01122019");
            chekbox1.Click();
            // Firststarttime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Start time"));
            //Firstendtime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "End time"));
            Firststarttime.SendKeys("1800");
            Firstendtime.SendKeys("2000");
            checkbox2.Click();
            //secondstarttime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Start time"));
            //secondendtime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "End time"));
            secondstarttime.SendKeys("1800");
            secondendtime.SendKeys("1800");
            if (skilltrade=="skillexchange")
            {
                skillexchange.Click();
                skillexchangetag.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "skillexchangetag1"));
            }
            else
            {
                credit.Click();
                creditamount.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "creditamount"));
            }
            //upload sample file
            clickfileupload.Click();
            AutoItX3 autoit = new AutoItX3();
            autoit.Run("C:\\Abi\\Geethu\\Autoit\\FileUpload.exe");
            Thread.Sleep(10000);
            active.Click();
            Thread.Sleep(7000);
            save.Click();

        }

        internal void Editnfill(string skilltrade)
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "shareskill");
            Title.Clear();
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Title"));
            Description.Clear();
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Description"));
            SelectElement selectcategory = new SelectElement(CategoryDropDown);
            selectcategory.SelectByText("Writing & Translation");
            SubCategoryDropDown.Click();
            SelectElement selectsubcategory = new SelectElement(SubCategoryDropDown);
            selectsubcategory.SelectByText("Translation");
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Firsttag"));
            Tags.SendKeys(Keys.Return);
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Secondtag"));
            ServiceTypeOptions.Click();
            LocationTypeOption.Click();
            StartDateDropDown.Click();
            StartDateDropDown.SendKeys("01112019");
            EndDateDropDown.SendKeys("01122019");
            chekbox1.Click();
            Firststarttime.SendKeys("1800");
            Firstendtime.SendKeys("2000");
            checkbox2.Click();
            secondstarttime.SendKeys("1800");
            secondendtime.SendKeys("1800");
            if (skilltrade == "skillexchange")
            {
                skillexchange.Click();
                skillexchangetag.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "skillexchangetag1"));
                Tags.SendKeys(Keys.Return);
                Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "skillexchangetag2"));
            }
            else
            {
                credit.Click();
                creditamount.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "creditamount"));
            }
            active.Click();
            save.Click();
        }
    }
}
