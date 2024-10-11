namespace MyAcademyChainOfResponsibility.DataAccess.Entities
{
	public class Team
	{
        public int TeamId { get; set; }
       public CustomerProcess CustomerProcess { get; set; }
		public string Job { get; set; }
    }
}
