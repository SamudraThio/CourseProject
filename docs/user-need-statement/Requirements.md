# Requirements

*****Web Page details:*****

Feature **Master Page
	A master page provides a template for other pages, with shared layout and functionality.
	The master page defines placeholders for the content, which can be overridden by content pages.
	The output result is a combination of the master page and the content page.
	The content pages contain the content you want to display.

Feature: **HOMEPAGE 
	The Home Screen will consist of the screen where one can select several options for what they want to do. 
	HOMEPAGE should display a fixed number of options on a page by a

Rule *Any user can browse the website, but special permissions are needed to view data within the database.

Scenario: Paging
    When user open the homepage it supposes to show them several options to go to.
    Then paging pages with navigation panel on the bottom of the page.

Scenario: Submitting Data 
    Given that the user is there to submit their information, they will click on the link to go submit their data.
    When user clicks on the button to submit their data 
    Then open the character submission page	

Feature: **Character submission
	This page consists of pre-set fields for users to submit details.

Scenario: Submit character information 
    Given users are visitors, they will be given a code before hand for the users to input which will correlate them to their guild.
    When users open CHARACTER SUBMISSION PAGE  
    Then they can add the information to the pre-set fields
	But users will have to input the code first
	
Feature: **Priveledged Roles Page
	Priveledged users can order view and query user inputs from here.

Scenario: Query items
    Given button with preset queries options will be displayed
    When user clicks on it
    Then result in a summary of the user input that have already been pre-queried.
	And user to view and extract data
	At this point, the user can change the query with the other buttons to continue analyzing data
	
Scenario Manually edit an item in the database
	When user click wants to make a correction
	they select the item from the database
	and update the data
	
Rule *Only privileged member can view and edit the database for members who have submitted data using their provided code.
	
Feature: **Contact Us Page
Visitors and Priveledged users can contact website owners or administrators from here.

Scenario send message to the administrators
Given contact us Page
When User enters following credentials and submit
|Name         |Email           |
|email        |test@test.com  |
|Message      |text           |
Then ‘Thank you to contact us’ message should be displayed
	
Rule *Contact Us page is available to contact Admin for queries.

Feature: **ABOUT US PAGE
	This page describes about website and owners

Feature: **LOGIN PAGE
	Login page for both users and administrators is the same

Rule *There are three roles available: Visitor, Priveledged User and Admin.
	Anyone can view Online Shopping portal and available products, 
	but every user must login by his/her Username and password in order to purchase or order products.

Feature: **ORDER VIEW FOR USER
	when users order item 
	then they are able to see ordered products and total amount.

Feature: **PAYPAL FOR PAYMENT
	Once users orders products they are redirected to payment page.

Feature **Admin Page
	Only difference you see in this page is Role: Admin. 
	User and Admin role will be checked once the page was login and Session role will be either Admin or User.
	If credentials belong to Admin then role will be Admin and if credentials belong to User then role will be User.

Role *An Admin has some extra privilege including all privilege of visitor and user.
		- Admin can generate codes for other guilds who register and set up an account and the pre-set code.
		- Admin can view all data on the database.
		- Only Admin will have access to modify roles, by default developer can only be an Admin;.

Feature **Success or Failed URL
	Inform user about success or failed transaction







