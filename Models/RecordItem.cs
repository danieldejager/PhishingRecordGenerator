namespace recordIem.EmailGenerator.Models {

    public class RecordItem {


        public RecordItem() {}

        public RecordItem(EmailModel model, int Clicks, int Opened, int Submitted, DateTime eventDateTime) {
            
            this.emailAddress = model;
            this.Clicks = Clicks;
            this.Opened = Opened;
            this.Submitted = Submitted;
            this.eventDateTime = eventDateTime;

        }

        public EmailModel? emailAddress { get; set; }

        public int? Clicks { get; set; }

        public int? Opened { get; set; }

        public int? Submitted { get; set; }

        public DateTime? eventDateTime { get; set; }

    }

}