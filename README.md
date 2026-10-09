# City of Cape Town Municipal Services Application

## Part 1 — Registration, Sign In and Municipal Issue Reporting

### Project overview

The **City of Cape Town Municipal Services Application** is a C# Windows Forms desktop application developed as a prototype to help residents engage with municipal services. Part 1 focuses on user registration, authentication, reporting municipal issues, and viewing previously submitted reports.

> **Note:** This is an academic prototype, not an official City of Cape Town application. It is not connected to the municipality's live service-request system.

### Requirements

- A Windows computer.
- Microsoft Visual Studio with the **.NET desktop development** workload installed.
- The **.NET Framework targeting/developer pack** matching the version configured in the project.
- The complete Visual Studio solution/project folder, including its source files, resources and configuration files.

No external database is required for the current prototype.

### 1. Open the project in Visual Studio

1. Extract the project folder if it was provided as a ZIP file.
2. Open **Visual Studio**.
3. Select **Open a project or solution**.
4. Navigate to the project folder and open the **`.sln`** solution file. If a solution file is not available, open the **`.csproj`** project file.
5. Wait for Visual Studio to finish loading the project.
6. In **Solution Explorer**, verify that the forms, models, services and resources are included in the project.

If Visual Studio reports that a .NET Framework targeting pack is missing, install the version requested by the project and reopen the solution.

### 2. Compile (build) the application

1. In Visual Studio, select **Build > Clean Solution** (optional, especially after changing code).
2. Select **Build > Build Solution**, or press **Ctrl + Shift + B**.
3. Check the **Output** window for the build result.
4. Confirm that the build finishes with **0 errors**.

If the build fails, open **View > Error List**, double-click the first error and correct it before rebuilding. Also check that required images and other project resources are present.

### 3. Run the application

1. In **Solution Explorer**, right-click the application project and choose **Set as Startup Project**, if necessary.
2. Press **F5** or select **Debug > Start Debugging**.
3. Alternatively, press **Ctrl + F5** to start without debugging.
4. The application's configured startup screen will open. Follow its navigation to the **Sign In** screen.

### 4. Register a new account

1. On the **Sign In** screen, click **Create an Account**.
2. Complete the registration form with the required details:
   - First name and last name.
   - Email address and phone number.
   - Residential address, suburb, city/area and postal code.
   - Password and confirm password.
3. Read and accept the **Terms and Conditions and Privacy Policy** checkbox.
4. Click **Create Account**.
5. If a required field is missing or invalid, review the validation message displayed near that field, correct the entry and submit again.
6. After successful registration, return to the sign-in process as directed by the application.

### 5. Sign in

1. Enter the email address used during registration.
2. Enter the account password.
3. Click **Sign In**.
4. If the details are incorrect, the application displays an error message.
5. If authentication succeeds, a success message appears and the **Home** screen opens.

The application starts a user session after a successful sign-in.

### 6. Submit a municipal issue (Part 1)

1. On the **Home** screen, open the **Report Issue** section.
2. Complete the issue-reporting form using the fields shown in the application. Describe the municipal problem clearly and provide the relevant location and any other required information.
3. Where the form provides an attachment option, add supporting evidence such as a photo if appropriate.
4. Click the form's **Submit** button.
5. Correct any validation errors if prompted.
6. After successful submission, review the confirmation and any report/reference number displayed.

**Example test issue:** A pothole on a local road, with a description of its location and the potential safety concern.

### 7. View submitted reports

1. Return to the **Home** screen.
2. Open **My Reports**.
3. Review the list of issues previously submitted through the application.
4. Select a report or its details option, if available, to review the recorded information.
5. Compare the displayed report with the details entered during submission to confirm that the report was captured correctly.

**Expected result:** The issue submitted in Step 6 appears in **My Reports**, together with the information and reference details supported by the application.

### 8. Suggested Part 1 testing checklist

- [ ] The application builds without compilation errors.
- [ ] The application launches successfully.
- [ ] The **Create Account** screen opens from **Sign In**.
- [ ] Required-field validation appears when registration information is missing.
- [ ] A valid user can register.
- [ ] Invalid sign-in credentials display an error.
- [ ] A registered user can sign in and reach **Home**.
- [ ] The **Report Issue** form opens.
- [ ] A valid issue can be submitted successfully.
- [ ] The submitted issue is visible under **My Reports**.
- [ ] The user can return to the Home screen and navigate between Part 1 features.

### 9. Important data-storage note

This prototype does **not** use an external database. Its application services and stores manage data locally within the implementation. Do not assume that accounts or submitted reports remain available after the application is closed unless persistence has been explicitly implemented and tested in the supplied project.

### 10. Troubleshooting

| Problem | What to check |
| --- | --- |
| Solution does not open | Open the correct `.sln` or `.csproj` file in Visual Studio. |
| Missing .NET Framework error | Install the targeting pack for the framework version specified by the project. |
| Build fails | Inspect **Error List** and confirm all project files and references are included. |
| Logo or images are missing | Check the project resources and ensure they are included in the build. |
| Registration does not proceed | Complete all required fields, verify input formats and accept the terms. |
| Sign-in fails | Use the registered email and correct password; review the validation message. |
| Report does not submit | Complete required issue details and resolve any validation errors. |
| Submitted report is not listed | Check **My Reports** during the same application session and confirm submission succeeded. |

### Scope of this README

**Included in Part 1:** Registration, sign-in, Home navigation, municipal issue submission, and viewing submitted reports.

**Not covered here:** Part 2 — Local Events and Announcements; Part 3 — Service Request Status Tracking.
