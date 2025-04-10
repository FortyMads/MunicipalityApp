Municipality Application
A comprehensive municipal management system allowing users to report issues, view local events and announcements, submit service requests, and provide feedback. The application supports user-friendly interfaces, seamless data management, and efficient reporting.

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
*******************************************************************************************************************
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

Features
1.	Report Issues
o	Location: Use Google Maps API for autocomplete location input.
o	Categories: Choose from three default categories or use the "Other" option to specify a custom category.
o	Description: Provide additional details about the issue in a text box.
o	Media Attachment: Attach any type of media (image, video, text, etc.) for more detailed issue reporting.
o	Progress Bar: Displays progress of the issue report, from entering details to completing submission.
2.	Local Events
o	Event Listings: View upcoming events along with their dates.
o	Search: Find events by name.
o	Advanced Filters: Filter events by date and category.
o	Recommendations: Display events based on frequently used categories, providing recommendations based on your preferences.
3.	Service Requests
o	Submit requests using detailed information, including issue descriptions and categories.
o	Maintain a status for each request, helping users track progress.
4.	Feedback
o	Submit feedback directly to the admin using a simple text-based feedback form

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
*******************************************************************************************************************
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

Technologies Used
•	C# for the application logic.
•	Google Maps API for location autocomplete.
•	text file for data persistence 
•	File I/O for media attachment (e.g., storing images or videos).
•	Windows Forms for the graphical user interface (GUI).
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
*******************************************************************************************************************
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

Prerequisites
To get this project up and running on your local machine, you'll need the following:
1.	Visual Studio: Make sure you have Visual Studio installed with the required C# development tools.
2.	.NET Framework: Ensure your system is running the necessary version of the .NET framework that the project uses.
3.	Google Maps API Key: You'll need a valid API key for Google Maps to enable the location autocomplete feature. but for test purposes i did include one(i know its poor practise to include my api keys but for markers purposes i didn't remove it)

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
*******************************************************************************************************************
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

Installation
Clone the Repository
1.	Open a terminal or Git Bash window.
2.	Clone the repository using the following command:
bash
Copy code
git clone https://github.com/FortyMads/municipality-app.git
3.	Navigate to the project directory:
bash
Copy code
cd municipality-app
Set Up the Project
1.	Open the project in Visual Studio.
2.	If you’re using Google Maps API, replace the placeholder API key in the relevant config files (e.g., appsettings.json) with your own API key.(I used my default for school purposes and know its bad practise to publicise API keys)
3.	Restore the NuGet packages by right-clicking the solution in Solution Explorer and selecting Restore NuGet Packages.
4.	Build the project using Build > Build Solution.

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
*******************************************************************************************************************
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

Usage
1.	Run the Application: In Visual Studio, click on Start (or press F5) to run the application.
2.	Reporting Issues: Navigate to the "Report Issues" section. Select the location (with autocomplete), choose a category, describe the issue, attach any media, and submit the report.
3.	Viewing Local Events: Navigate to the "Local Events" section. View upcoming events, filter by category or date, or search for specific events.
4.	Service Requests: Use the "Service Requests" section to log service requests and track their progress.
5.	Feedback: Submit feedback through the feedback button for communication with the admin.

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
*******************************************************************************************************************
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

Contributing
If you'd like to contribute to the project, feel free to fork the repository and submit pull requests. Please ensure that your code follows the existing coding conventions and add unit tests for new functionality where applicable.

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
*******************************************************************************************************************
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

License
This project is licensed under the MIT License - see the LICENSE file for details.

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
*******************************************************************************************************************
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

This README should provide a clear understanding of how to set up, use, and contribute to the application. Additionally, the technologies mentioned are suggestions for future enhancements that can improve scalability, performance, and functionality.
