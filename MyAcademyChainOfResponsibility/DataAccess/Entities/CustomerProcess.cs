namespace MyAcademyChainOfResponsibility.DataAccess.Entities
{
	public class CustomerProcess
	{
        public int CustomerProcessId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string EmployeeName { get; set; }
        public string Description { get; set; }
		public List<Team> Teams { get; set; }
	}
}
