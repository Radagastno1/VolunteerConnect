namespace CORE;
public class VolunteerOpportunity{
    public string Id { get; set; }
    public string AnimalShelterId { get; set; }
    public string Title{get;set;}
    public string Description{get;set;}
    public DateTime StartDate{get;set;}
    public DateTime EndDate{get;set;}
    public string RequiredSkills{get;set;}
}