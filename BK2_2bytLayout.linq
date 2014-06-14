<Query Kind="Statements">
  <Reference Relative="Coypu.dll">&lt;MyDocuments&gt;\GitHub\testa-mallgrodan\Coypu.dll</Reference>
  <Reference Relative="WebDriver.dll">&lt;MyDocuments&gt;\GitHub\testa-mallgrodan\WebDriver.dll</Reference>
  <Namespace>Coypu</Namespace>
</Query>

var browser = new BrowserSession();
browser.Visit("http://www.mallgrodan.se");
browser.Select("StyleLayoutTwo.css").From("layoutThemes");
browser.Select("StyleLayoutSimple.css").From("layoutThemes");