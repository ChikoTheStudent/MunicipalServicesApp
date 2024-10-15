using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MunicipalServicesApp
{
    public partial class LocalEventsForm : Form
    {
        private Dictionary<string, List<Event>> eventsByCategory;

        public LocalEventsForm()
        {
            InitializeComponent();
            InitializeDataStructures();
            LoadEventsFromDatabase();
            LoadUpcomingEvents();
        }

        private void InitializeDataStructures()
        {
            eventsByCategory = new Dictionary<string, List<Event>>();
        }

        private void LoadEventsFromDatabase()
        {
            string connectionString = "server=localhost;database=municipal_services_new;uid=root;pwd=Strawhat@01;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT event_id, event_name, event_description, event_date, category, location FROM events";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int eventId = reader.GetInt32(0);
                        string eventName = reader.GetString(1);
                        string eventDescription = reader.IsDBNull(2) ? null : reader.GetString(2);
                        DateTime eventDate = reader.GetDateTime(3);
                        string category = reader.IsDBNull(4) ? null : reader.GetString(4);
                        string location = reader.IsDBNull(5) ? null : reader.GetString(5);

                        Event evt = new Event(eventId, eventName, eventDescription, eventDate, category, location);

                        if (!eventsByCategory.ContainsKey(category))
                        {
                            eventsByCategory[category] = new List<Event>();
                        }
                        eventsByCategory[category].Add(evt);
                    }
                }
            }
        }

        private void LoadUpcomingEvents()
        {
            // Clears existing items
            lstUpcomingEvents.Items.Clear(); 

            string connectionString = "server=localhost;database=municipal_services_new;uid=root;pwd=Strawhat@01;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT event_name, event_date, category FROM events WHERE event_date >= CURDATE()";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string eventName = reader.GetString("event_name");
                        DateTime eventDate = reader.GetDateTime("event_date");
                        string category = reader.GetString("category");
                        lstUpcomingEvents.Items.Add($"{eventName} - {eventDate.ToShortDateString()} ({category})");
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string category = txtCategory.Text.Trim();
            string dateText = txtDate.Text.Trim();
            DateTime eventDate = DateTime.MinValue;

            lstEvents.Items.Clear();
            lstRecommendations.Items.Clear();

            if (!string.IsNullOrEmpty(dateText) && !DateTime.TryParse(dateText, out eventDate))
            {
                MessageBox.Show("Please enter a valid date.");
                return;
            }

            var filteredEvents = eventsByCategory.SelectMany(kvp => kvp.Value)
                .Where(evt => (string.IsNullOrEmpty(category) || evt.Category.Equals(category, StringComparison.OrdinalIgnoreCase)) &&
                              (string.IsNullOrEmpty(dateText) || evt.EventDate.Date == eventDate))
                .ToList();

            foreach (var evt in filteredEvents)
            {
                lstEvents.Items.Add($"{evt.EventName} - {evt.EventDate.ToShortDateString()}");
            }

            if (!string.IsNullOrEmpty(category) && eventsByCategory.ContainsKey(category))
            {
                foreach (var eventInCategory in eventsByCategory[category].Where(eventInCategory => !filteredEvents.Contains(eventInCategory)))
                {
                    lstRecommendations.Items.Add($"{eventInCategory.EventName} - {eventInCategory.EventDate.ToShortDateString()}");
                }
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lstRecommendations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstUpcomingEvents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    // Event class that holds event details
    public class Event
    {
        public int EventId { get; }
        public string EventName { get; }
        public string EventDescription { get; }
        public DateTime EventDate { get; }
        public string Category { get; }
        public string Location { get; }

        // Event constructor
        public Event(int eventId, string eventName, string eventDescription, DateTime eventDate, string category, string location)
        {
            EventId = eventId;
            EventName = eventName;
            EventDescription = eventDescription;
            EventDate = eventDate;
            Category = category;
            Location = location;
        }
    }
}
