<Query Kind="Statements">
  <Reference Relative="Coypu.dll">&lt;MyDocuments&gt;\GitHub\testa-mallgrodan\Coypu.dll</Reference>
  <Reference Relative="WebDriver.dll">&lt;MyDocuments&gt;\GitHub\testa-mallgrodan\WebDriver.dll</Reference>
  <Namespace>Coypu</Namespace>
</Query>

var browser = new BrowserSession();
browser.Visit("http://www.mallgrodan.se");
browser.FillIn("email").With("masterfrog@frog.se");
browser.FillIn("password").With("frog");
browser.ClickButton("loginButton");
browser.Select("StyleLayoutTwo.css").From("layoutThemes");