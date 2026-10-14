City of Cape Town Municipal Services Application
Advanced Application Development (AAPD7112) — Part 1 and Part 2
Student number: ST10389901
Developer: Zesande Mbekwa
Academic prototype: This is an educational Windows desktop application, not an official City of Cape Town product. It is not connected to the municipality's live systems, and the reports shown here are not submitted to the City.

Project overview
The City of Cape Town Municipal Services Application is a C# Windows Forms (.NET Framework) desktop prototype that provides separate Citizen and Administrator portals. Citizens can register, sign in, submit municipal issue reports, review their reports, and browse local events and announcements. Administrators can review submitted issues, inspect attachments, change request statuses, manage users, and publish events and announcements.
Part 2 extends the registration and issue-reporting features from Part 1 with administrator workflows, citizen-facing status updates, event and announcement management, and event recommendations based on user interactions.
Demonstration and source code
- Video demonstration: https://youtu.be/f4Mbzu8wlM0
- GitHub repository: https://github.com/ZesandeMbekwa101/CityOfCapeTownMunicipalServices
Features
Citizen Portal
- Account registration: Create an account using personal and address information, subject to form validation.
- Sign in and sign out: Authenticate and access citizen-specific screens.
- Report an issue: Provide a location, category, description, and optional supporting attachment. Successful submissions receive a reference number.
- My Reports: Review submitted issues, search or filter by status, and view progress indicators.
- Local Events and Announcements: Search and browse published municipal items, use category filters, and open item details.
- Recommended for You: View event recommendations informed by recorded search and category interests.
Administrator Portal
- Role-based access: Administrator accounts open the admin dashboard instead of the citizen dashboard.
- Service Request Management: Search and filter citizen submissions, review details and attachments, and change statuses such as Pending, In Progress, Resolved, and Rejected. Status labels in citizen-facing screens may differ depending on the implementation.
- User Management: View registered users and their roles, search and filter accounts, and access the Add User action.
- Event Management: Add, edit, delete, search, and filter municipal events.
- Announcement Management: Add, edit, delete, search, and filter municipal announcements.
- Separate category choices: The editor presents event-specific categories for events and announcement-specific categories for announcements.
- Dashboard navigation: Includes Service Requests, Events, Announcements, Users, Resources, and Settings sections. The presence of a dashboard section does not necessarily mean every underlying feature is implemented.
Application workflow
1. The application opens with a splash screen and provides access to registration or sign-in.
2. A citizen registers, signs in, and opens the Citizen Portal.
3. The citizen submits a municipal issue and receives a reference number.
4. The issue appears in the citizen's My Reports screen and in the administrator's Service Requests management screen, provided both use the shared application store.
5. An administrator signs in, opens the report, optionally reviews its attachment, and changes its status.
6. The citizen returns to My Reports to see the updated status and progress indicator.
7. Administrators add events and announcements through their respective management pages.
8. Citizens browse those items in Local Events and Announcements and can open Recommended for You for suggestions based on recorded interactions.
Technologies and project structure
- Language: C#
- UI framework: Windows Forms on .NET Framework
- IDE: Microsoft Visual Studio
- Data structures: In-memory collections such as List<T>, Dictionary<TKey,TValue>, SortedDictionary<TKey,TValue>, HashSet<T>, Stack<T>, and Queue<T>
Folder / file	Purpose
Forms/	Citizen, authentication, and administrator Windows Forms screens
Models/	Application data models such as IssueReport and MunicipalEvent
DataStructures/	Stores and collection-based data operations, including IssueStore and EventStore
Services/	User/session and application services
Helpers/	Shared helper functionality
Resources/ and Properties/	Images, branding, and project resources
Program.cs	Application entry point
App.config	Application configuration
CityOfCapeTownMunicipalServices.csproj	Windows Forms project
CityOfCapeTownMunicipalServices.slnx	Visual Studio solution file


Data structure examples
- IssueStore: Maintains submitted reports in a List<IssueReport> and supports retrieving all reports, finding a report by reference, and filtering reports by user email.
- EventStore: Organises events by date with a SortedDictionary, looks up events by ID with a Dictionary, tracks categories with a HashSet, records searches in a Stack, and tracks recent category interests in a Queue.
- Recommendation information: Category-interest counts can be used to identify categories the citizen has interacted with most often.
Requirements
- Windows computer
- Visual Studio with the .NET desktop development workload
- The .NET Framework Developer/Targeting Pack matching the target framework in CityOfCapeTownMunicipalServices.csproj
- All project source files, images, and resources
No external database is required for the current in-memory prototype.
How to build and run
1. Clone or download this repository:git clone https://github.com/ZesandeMbekwa101/CityOfCapeTownMunicipalServices.git
2. Open CityOfCapeTownMunicipalServices.slnx in a compatible Visual Studio version. If necessary, open CityOfCapeTownMunicipalServices.csproj directly.
3. Allow Visual Studio to load the project and resolve references.
4. Install the required .NET Framework targeting pack if prompted.
5. Select Build > Build Solution or press Ctrl + Shift + B.
6. Set CityOfCapeTownMunicipalServices as the startup project if necessary.
7. Press F5 to run with debugging, or Ctrl + F5 to run without debugging.
How to test the main features
Citizen workflow
1. From Sign In, select Create an Account and complete the registration form.
2. Sign in with the registered account.
3. Select Report Issue and enter the location, category, description, and optional attachment.
4. Submit the report and record its generated reference number.
5. Open My Reports and confirm that the new report appears.
6. Open Local Events and Announcements to browse available items, search by text, and select categories.
7. View item details and try Recommended for You after interacting with event categories.
Administrator workflow
1. Sign in with an administrator account configured in the project's user store.
2. Open Service Requests and locate the report submitted in the citizen workflow.
3. Select View Details to inspect its information and any available attachment.
4. Select Change Status, choose a new status, and confirm the update.
5. Return to the citizen's My Reports screen and verify the new status appears.
6. Open Events, add an event, and verify that it appears in the management list.
7. Open Announcements, add an announcement, and verify that it appears in its management list.
8. Return to the citizen portal and confirm that published items appear in the Local Events and Announcements screen.
Admin credentials: Use the administrator account defined in the application's user store. Do not commit real passwords or secrets to the README or repository.

Important limitations
- In-memory storage: The provided IssueStore and EventStore use static in-memory collections. Records are available only within the same running application process and are lost when that process exits unless separate persistence has been implemented.
- Not a live municipal service: Submissions do not create official City of Cape Town service requests.
- Attachments: Files referenced by an attachment path must still exist at that path for an administrator to open them.
- Recommendations: Recommendations are based on application-recorded searches and category interactions, not an external recommendation service.
- Demo scope: Features should be evaluated against the supplied implementation; some dashboard sections may be placeholders or future work.
Troubleshooting
Problem	What to check
Solution will not open	Use a compatible Visual Studio version and open the .slnx or .csproj file.
Missing .NET Framework	Install the target framework's Developer/Targeting Pack.
Build errors	Review Error List, references, namespaces, and missing resources.
Images or logo missing	Confirm resource files are present and included in the project.
Registration fails	Check required fields, formats, password confirmation, and terms acceptance.
Sign-in fails	Check the account credentials and assigned role.
Submitted request missing from admin portal	Ensure the citizen form saves to IssueStore and the admin page reads from that same store in the same running process.
Status does not update	Confirm the admin changes the stored IssueReport and refresh the citizen's report list.
Events list is empty	Add events through the administrator portal; sample events are not automatically populated.
Attachment does not open	Confirm the file still exists at its saved path.
Data disappears after restart	This is expected with the current in-memory stores. Add persistence if required.


Academic scope
- Part 1: Registration, authentication, citizen home navigation, issue submission, and report viewing.
- Part 2: Administrator portal, issue management and status updates, user management, event and announcement creation/management, citizen event browsing, and event recommendations.
Disclaimer
This repository is an academic prototype created for coursework. It is not affiliated with, endorsed by, or integrated into the official City of Cape Town municipal service systems.
