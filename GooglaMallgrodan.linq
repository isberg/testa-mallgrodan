<Query Kind="Statements">
  <Reference Relative="Coypu.dll">C:\Users\Jonas\Projects\testa-mallgrodan\Coypu.dll</Reference>
  <Reference Relative="WebDriver.dll">C:\Users\Jonas\Projects\testa-mallgrodan\WebDriver.dll</Reference>
  <Namespace>Coypu</Namespace>
</Query>

var browser = new BrowserSession();
browser.Visit("http://www.google.se");
browser.FillIn("q").With("mallgrodan");