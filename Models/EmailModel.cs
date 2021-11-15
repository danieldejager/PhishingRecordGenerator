namespace recordIem.EmailGenerator.Models {

public class EmailModel {

    public EmailModel() {}

    public EmailModel(String FirstName, String LastName, String DomainName) {

        this.FirstName = FirstName;
        this.LastName = LastName;
        this.DomainName = DomainName;
    }

    public String? FirstName {get;set;}
    public String? LastName { get; set; }
    public String? DomainName {get;set;}

    }

}