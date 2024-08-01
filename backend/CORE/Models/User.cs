namespace CORE;
public class User
{
    public string Id{get;set;}
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public string PasswordHash{get;set;}   
    public string Role{get;set;}
    public DateTime JoinedDate{get;set;}
    public int Points{get;set;}

}
