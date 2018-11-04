1. How to get hints or quick fixes in Visual Studio
	ans: using ctrl+.
2. Unable to find OpenQA.Selenium.Support
	ans: Selenium.Support is separate package need to install from NuGet Package Manager
3. After write test, if I go to "Test Explorer", I am not able to see my tests. {Test > Window > Test Explorer}
	ans: Need to install "NUnit3 Test Adaptor". This can be install by following below steps.
		a. Navigate to "Extentions and Update dialog" by "Tools > Extentions and Update"
		b. Go to Online from left panel.
		c. Search "NUnit3 Test Adaptor" and click update
4. Unable to install package "Selenium.Support", getting error "An error occurred while retriving metata data for NUnit3"
	ans: This resolved by updating "NuGet Package Manager" by following below steps
			a. In Visual Studio, from the "Tools" menu choose the "Extensions and Updates" option.
			b. From the dialog that appears, expand the "Updates" node from the tree at the left side.
			c. Select the "Visual Studio Gallery" option from the tree.
			d. Finally, look for the Package Manager update in the list of updates at the right side of the dialog and click the "Update" button beside it.
5. After using PageFactory.InitElements from "Selenium.PageObject", received warning thet "PageFactory" is depricated.
	sol: PageFactory project moved to another binding called "DotNetSeleniumExtras.PageObjects", after install this package and changed using package it works.