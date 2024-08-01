namespace CORE;
public class VolunteerSchedule{
    public string Id { get; set; }
    public string VolunteerOpportunityId{ get; set; }
    public string UserId { get; set; }
    public DateTime ScheduledDate{get;set;}
    public int Hours{get;set;}
}   