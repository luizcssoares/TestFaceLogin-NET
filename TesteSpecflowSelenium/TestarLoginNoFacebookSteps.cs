using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace TesteSpecflowSelenium
{
    [Binding]
    public class TestarLoginNoFacebookSteps
    {

        IWebDriver browser;
        private string url = "https://www.facebook.com/";

        [BeforeScenario]
        public void Init() {
            this.browser = new ChromeDriver();
        }

        [AfterScenario]
        public void Close() {
            this.browser.Close();
            this.browser.Dispose();
        }

        [Given(@"Abra Navegador e Start Aplicacao")]
        public void DadoAbraNavegadorEStartAplicacao()
        {
            this.browser.Navigate().GoToUrl(url);            
        }
        
        [When(@"Eu entro com usuario e password validas")]
        public void QuandoEuEntroComUsuarioEPasswordValidas()
        {
            this.browser.FindElement(By.Id("email")).SendKeys("luizcssoares@gmail.com");
            this.browser.FindElement(By.Id("pass")).SendKeys("lucas@2001");
        }
        
        [Then(@"Usuario deve fazer Login com sucesso")]
        public void EntaoUsuarioDeveFazerLoginComSucesso()
        {
            var btnLogin = this.browser.FindElement(By.Id("loginbutton"));
            btnLogin.Click();
        }
    }
}
