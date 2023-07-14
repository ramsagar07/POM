using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using POM.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POM.Support;
using System.Xml.Linq;

namespace POM.StepDefinitions
{
    [Binding]
    public class AllAroundSteps
    {
        private AndroidDriver<AndroidElement> driver;
        
        private HearInNoise hearinnoise;
        private AllAround allaround;
        private Outdoor outdoor;
        private Music music;
        private TopRibbonBar topbar;
        private ProgramOverView programOverView;
        private MyResound myresound;
        private LearnAboutApp learnAboutApp;
        private GuidingTips guidingTips;
        private More more;
        private LegalInformation legalinfo;
        public AllAroundSteps(AndroidDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }
        [Given(@"I am on All-Around page and i validate the program card is ""([^""]*)""")]
        public void GivenIAmOnPageAllAroundAndIValidateTheProgramCardIs(string title) //Validates the title of program card All-Around
        {
            allaround = new AllAround(driver);
            allaround.VerifyModeName(title);
            
        }

        
        [When(@"i press split sourruounding volume on All-Around program")]//presses the split button on All-Around
        public void WhenIPressSplitSourruoundingVolumeOnAllAroundProgram()
        {
            allaround.PressSplitButton();
        }
        [Then(@"i validate ""([^""]*)"" volume is '([^']*)'")]//validates the LEFT and Right sorrunding volume bars volume
        public void ThenIValidateVolumeIs(string HI, string value)
        {
            allaround.ValidateHI_Value(HI, value);
        }
        [When(@"i set ""([^""]*)"" sourrounding volume to ""([^""]*)"" of All-Around program")]
        public void WhenISetSourroundingVolumeToOfAll_AroundProgram(string hI, string target)
        {
            allaround.move_sliders(hI, target);
        }

        [When(@"i press merge sourrounding voulume on All-Around program")]
        public void WhenIPressMergeSourroundingVoulumeOnAll_AroundProgram()
        {
            allaround.click_merge();
        }

        [When(@"i press '([^']*)' quick button on All-Around Program")]
        public void WhenIPressQuickButtonOnAllAroundProgram(string buttonname)
        {
            allaround.clickquickbutton(buttonname);
        }

        [Then(@"validate '([^']*)' quick button is enabled on All-Around Program")]
        public void ThenIvalidateQuickButtonIsEnabledOnAllAroundProgram(string button)
        {
            allaround.isenabled(button);
        }

        [Then(@"validate '([^']*)' quick button is disabled on All-Around program")]
        public void ThenValidateQuickButtonIsDisabledOnAllAroundProgram(string button)
        {
            allaround.isdiabled(button);
        }
        [When(@"i set '([^']*)' to '([^']*)' on All-Around Sound Enhancer")]
        public void WhenISetToOnAll_AroundSoundEnhancer(string gain, string target)
        {
            allaround.MoveGainSliders(gain, target);
        }

        [Then(@"i validate ""([^""]*)"" is ""([^""]*)"" on All-Around Sound Enhancer")]
        public void ThenIValidateIsOnAll_AroundSoundEnhancer(string gain, string value)
        {
            allaround.ValidateGainValue(gain, value);
        }
        

        [When(@"i press Nature sounds button ""([^""]*)"" on All-Around Tinnitus Manager")]
        public void WhenIPressNatureSoundsButtonOnAll_AroundTinnitusManager(string wave_type)
        {
            allaround.PressNatureWaves(wave_type);
        }
        [Then(@"i validate program card is ""([^""]*)""")]
        public void ThenIValidateProgramCardIs(string title)
        {
            
            switch(title.ToUpper())
            {
                case "HEAR IN NOISE":
                    hearinnoise = new HearInNoise(driver);
                    hearinnoise.VerifyModeName(title);
                    break;
                case "OUTDOOR":
                    outdoor = new Outdoor(driver);
                    outdoor.VerifyModeName(title);
                    break;
                case "MUSIC":
                    music = new Music(driver);
                    music.VerifyModeName(title);
                    break;

            }
            
        }

       

        [When(@"i press Sound Enhancer button on '([^']*)' program")]
        public void WhenIPressSoundEnhancerButtonOnProgram(string program)
        {
            switch (program.ToUpper())
            {
                case "ALL AROUND":
                    allaround.PressSoundenhancer();
                    break;

                case "HEAR IN NOISE":
                    hearinnoise.PressSoundenhancer();
                    break;
                case "OUTDOOR":
                    outdoor.PressSoundenhancer();
                    break;
            }
        }

        [When(@"i press Tinnitus Manager on '([^']*)' Sound Enhancer")]
        public void WhenIPressOnSoundEnhancer(string program)
        {
            switch(program.ToUpper())
            {
                case "HEAR IN NOISE":
                    hearinnoise.pressTinnitusManager();
                    break;
                case "ALL AROUND":
                    allaround.pressTinnitusManager();
                    break;

            }
        }
        [When(@"i press white noise button Slight variation on Hear in noise Tinnitus Manager")]
        public void WhenIPressWhiteNoiseButtonSlightVariationOnTinnitusManager()
        {
            hearinnoise.pressSlightvariation();
        }

        [When(@"i press Reset button on All-Around Tinnitus Manager")]
        public void WhenIPressResetButtonOnAll_AroundTinnitusManager()
        {
            hearinnoise.pressReset();
        }

        [When(@"i press the exit button on '([^']*)' Sound Enhancer")]
        public void WhenIPressTheExitButtonOnSoundEnhancer(string program)
        {
            switch(program.ToUpper())
            {
                case "ALL AROUND":
                    allaround.PressExitTinnitusManager();
                    break;
                case "HEAR IN NOISE":
                    hearinnoise.PressExitTinnitusManager();
                    break;
                case "OUTDOOR":
                    outdoor.PressExitTinnitusManager();
                    break;

            }
           
        }

        [When(@"i swipe left to '([^']*)' program from current program")]
        public void WhenISwipeToProgramFromCurrentProgram(string program)
        {
            switch(program.ToUpper())
            {
                case "HEAR IN NOISE":
                   allaround.Swipeleft();
                    break;
                case "OUTDOOR":
                   hearinnoise.Swipeleft();
                    break;
                case "MUSIC":
                    outdoor.Swipeleft();
                    break;
            }
        }


       
        [When(@"i drag Wind Noise Reduction to Strong on Outdoor Sound Enhancer")]
        public void WhenIDragWindNoiseReductionToStrongOnOutdoorSoundEnhancer()
        {
            outdoor.set_wind_noiseReductionToStorng();
        }
        [When(@"I press '([^']*)' program on the top ribbon bar")]
        public void WhenIPressProgramOnTheTopRibbonBar(string program)
        {
            topbar = new TopRibbonBar(driver);
            topbar.press_program(program);
        }
        [When(@"i press Program overview button on topribbonbar")]
        public void WhenIPressProgramOverviewButtonOnTopribbonbar()
        {
            topbar.pressProgramOverview();
        }

        [When(@"i press '([^']*)' program on Program overview")]
        public void WhenIPressProgramOnProgramOverview(string program)
        {
            programOverView = new ProgramOverView(driver);
            programOverView.press_program(program);
        }

        [When(@"i press the Close button on Program overview")]
        public void WhenIPressTheCloseButtonOnProgramOverview()
        {
           programOverView.press_Close();
        }
        [When(@"i press menu item '([^']*)' on bottom ribbon bar")]
        public void WhenIPressMenuItemOnBottomRibbonBar(string menu_item)
        {
            if (menu_item.ToUpper() == "MY RESOUND")
            {
                programOverView.preeMyresound();
            }
            else if(menu_item.ToUpper() == "HOME")
            {
                more.Press(menu_item);
            }
            else
            {
                guidingTips.Press(menu_item);
            }
        }
        [When(@"I press '([^']*)' on My ReSound")]
        public void WhenIPressOnMyReSound(string function)
        {
            myresound = new MyResound(driver);
            myresound.press_program(function);

        }
        [When(@"I press Volume control on Learn about the app")]
        public void WhenIPressVolumecontrolOnLearnAboutTheApp()
        {
            learnAboutApp = new LearnAboutApp(driver);
            learnAboutApp.clickvolumeControl();
        }
        [When(@"I swipe left to '([^']*)' page on Learn about the app")]
        public void WhenISwipeLeftToPageOnLearnAboutTheApp(string page)
        {
            learnAboutApp.swipeleft(page);
        }
        [Then(@"validate '([^']*)' animation is shown on Volume control")]
        public void ThenValidateAnimationIsShownOnVolumeControl(string animation_name)
        {
            learnAboutApp.validateAnimation(animation_name);
        }
        [When(@"I close on Learn about the app and back to My Resound page")]
        public void WhenICloseOnLearnAboutTheAppAndBackToMyResoundPage()
        {
           learnAboutApp.pressclose();
        }
        [When(@"I press '([^']*)' on Please notice dialog")]
        public void WhenIPressOnDialog(string prog)
        {
            guidingTips = new GuidingTips(driver);
            guidingTips.Press(prog);
        }
        [Then(@"validate title is '([^']*)' on Guiding tips page")]
        public void ThenValidateTitleIsOnGuidingTipsPage(string title)
        {
            guidingTips.ValidateTitle(title);
        }
        [When(@"I press '([^']*)' on Guiding tips")]
        public void WhenIPressOnGuidingTips(string program)
        {
            guidingTips.Press(program);
        }

        [When(@"I press '([^']*)' on '([^']*)' nudging dialog")]
        public void WhenIPressOnNudgingDialog(string gotit, string program)
        {
            guidingTips.Press(gotit);
        }

        [When(@"I press '([^']*)' on bottom ribbon bar and back to Guiding tips on My Resound")]
        public void WhenIPressOnBottomRibbonBarAndBackToOnMyResound(string program)
        {
            guidingTips.Press(program);
        }
        [Then(@"validate '([^']*)' button enabled on Music program nudging dialog")]
        public void ThenValidateButtonEnabledOnNudgingDialog(string name)
        {
            guidingTips.ValidateEnabled(name);
        }

        [Then(@"validate Auto-activate favorite locations switch is '([^']*)'")]
        public void ThenValidateSwitchIs(string on_off)
        {
            more = new More(driver);
            more.ValidateOnOff(on_off);
        }

        [When(@"I press '([^']*)' switch on More menu")]
        public void WhenIPressSwitchOnMoreMenu(string name)
        {
            more.Press(name);
        }
        [When(@"I press more menu item '([^']*)'")]
        public void WhenIPressMoreMenuItem(string about)
        {
            more.Press(about);
        }

        [Then(@"validate page title is displayed on '([^']*)' page")]
        public void ThenValidatePageTitleIsDisplayedOnAboutPage(string about)
        {
            more.ValidatePageTitleDisplayed(about);
        }

        [When(@"I press '([^']*)' from '([^']*)' page")]
        public void WhenIPressBackFromPage(string back, string about)
        {
           if(about.ToUpper() == "ABOUT")
            {
                more.Press(back);
            }
            else
            {
                legalinfo.Press(back);            
            }
            
        }
      

        [Then(@"I validate page title is displayed on '([^']*)' page")]
        public void ThenIValidatePageTitleIsDisplayedOnPage(string name)
        {
            legalinfo.ValidatePageTitleDisplayed(name);
        }

        [When(@"I press back from '([^']*)' page")]
        public void WhenIPressBackFromPage(string manufacturer)
        {
            legalinfo.Press(manufacturer);
        }

        [When(@"I press Legal information item '([^']*)'")]
        public void WhenIPressLegalInformationItem(string name)
        {
            legalinfo = new LegalInformation(driver);
            legalinfo.Press(name);
        }
        [Then(@"validate html view is displayed on '([^']*)' page")]
        public void ThenValidateHtmlViewIsDisplayedOnPage(string name)
        {
            if(name.ToUpper() == "ABOUT")
            {
                more.ValidateHtmlView();
            }
            else
            {
                legalinfo.ValidateHtmlView();
            }
        }

       




    }
}
