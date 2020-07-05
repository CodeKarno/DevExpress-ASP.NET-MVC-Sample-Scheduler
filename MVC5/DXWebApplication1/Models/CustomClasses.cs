using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DXWebApplication1.Models {
	public class CustomAppointment {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Subject { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public int Label { get; set; }
        public string Location { get; set; }
        public bool AllDay { get; set; }
        public int EventType { get; set; }
        public string RecurrenceInfo { get; set; }
        public string ReminderInfo { get; set; }
        public string OwnerId { get; set; }
        public int ID { get; set; }

        public CustomAppointment() {
		}

		public static CustomAppointment CreateCustomAppointment(string subject, object resourceId, int status, int label, int id) {
			CustomAppointment apt = new CustomAppointment();
			apt.ID = id;
			apt.Subject = subject;
			apt.OwnerId = String.Format("<ResourceIds>\r\n<ResourceId Type=\"System.Int32\" Value=\"{0}\"/>\r\n</ResourceIds>", resourceId);
			apt.StartTime = DateTime.Now.AddHours(id);
			apt.EndTime = apt.StartTime.AddHours(3);
			apt.Status = status;
			apt.Label = label;
			return apt;
		}
	}

	public class CustomResource {
        public string Name { get; set; }
        public int ResID { get; set; }
        public int Color { get; set; }

        public CustomResource() {

		}

		public static CustomResource CreateCustomResource(int res_id, string caption, int ResColor) {
			CustomResource cr = new CustomResource();
			cr.ResID = res_id;
			cr.Name = caption;
			cr.Color = ResColor;
			return cr;
		}

	}

	public class SchedulerDataObject {
		public List<CustomAppointment> Appointments { get; set; }
		public List<CustomResource> Resources { get; set; }
	}
}