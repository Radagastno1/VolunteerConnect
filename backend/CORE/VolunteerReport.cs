namespace CORE;
public class VolunteerReport{
    public string Id{get;set;}
    public string UserId{get;set;}
    public string VolunteerOpportunityId{get;set;}
    public DateTime ReportDate{get;set;}
    public string Description{get;set;}
    public int HoursReported{get;set;}
}