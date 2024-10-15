===============================================
Municipal Services Application - README
===============================================

Developed by: [Chikomborero Christopher Muvavarirwa] [st10114706]
Version: [v2.0]

======================================================
Table of Contents
======================================================
1. How to Run the Application
2. Report Issues Feature
3. Local Events and Announcements Feature
4. Additional Notes
======================================================

======================================================
1. How to Run the Application
======================================================

- Run the application by clicking the "Start" button in Visual Studio or by pressing F5.
- The main menu will display the following options:
  - "Report Issues" (Enabled)
  - "Local Events and Announcements" (Enabled)
  - "Service Request Status" (Disabled for now)
- Click on the "Report Issues" button to submit an issue.
- Click on "Local Events and Announcements" to view and search for upcoming events.

======================================================
2. Report Issues Feature
======================================================

- **Location**: Enter the location of the issue in the "Location" textbox.
- **Category**: Select the issue category from the dropdown (e.g., Sanitation, Roads, Utilities).
- **Description**: Provide a detailed description of the issue in the "Description" box.
- **Attach File**: Click the "Attach File" button to add any relevant media. The path of the attached file will appear in the label.
- **Submit**: Click "Submit" to report the issue. If all fields are properly filled, a confirmation will appear, and the issue will be stored in the system.
- **View All Reports**: Inside the "Report Issues" form, click the "View All Reports" button to see a list of all submitted reports.
- **Back to Main Menu**: Use the "Back to Main Menu" button to return to the main screen.

======================================================
3. Local Events and Announcements Feature
======================================================

- **Upcoming Events**: 
  - The Local Events page will display a list of upcoming events from the database under the "Upcoming Events" section.
  - The list includes the event name, date, and category.

- **Search for Events**:
  - **Category Search**: Enter a category (e.g., Community, Arts, Music, Sports, Food, Education) in the "Category" textbox and press "Search" to filter events.
  - **Date Search**: Enter a specific date (MM/DD/YYYY) in the "Date" textbox to find events on that date.
  - **Combined Search**: You can enter both category and date to search for events that match both criteria.

- **Search Results**:
  - After performing a search, matching events will appear in the "Search Results" section.
  - Results will display the event name and date.

- **Recommendations**:
  - If you search by category, events within that category but not matching the exact search criteria will appear in the "Recommendations" section.
  - These recommendations help users discover other events in their area.

- **User Interface**:
  - The page is designed to provide a clear layout with labels and input fields for category and date.
  - The results and recommendations are displayed in separate list boxes for easy navigation.

- **Back to Main Menu**:
  - Use the "Back to Main Menu" button to return to the main menu at any time.

======================================================
4. Additional Notes
======================================================

- **Validation**:
  - If invalid data is entered (e.g., incorrect date format), an error message will be displayed.
  - Required fields must be completed to successfully perform searches.

- **Data Loading**:
  - Events are automatically loaded from the database upon opening the Local Events form. Only upcoming events will be shown.

- **Future Updates**:
  - The "Service Request Status" feature is currently disabled. This functionality will be available in future updates.

======================================================
