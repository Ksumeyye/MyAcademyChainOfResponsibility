using MyAcademyChainOfResponsibility.DataAccess.Context;
using MyAcademyChainOfResponsibility.Models;

namespace MyAcademyChainOfResponsibility.ChainOfResponsibility
{
	public class Clerk: Employee
	{
		private readonly CoFContext _context;
	
		public Clerk(CoFContext context)
		{
			_context = context;
		}
		public override void Process(CustomerProcessViewModel request)
		{
			if (request.Price <= 50000)
			{
				var customerProcess = new CustomerProcessViewModel
				{
					Name = request.Name,
					Price = request.Price,
					EmployeeName = "Burcu Meşe - Gişe Memuru",
					Description = "Para çekme işlemi başarıyla gerçekleşti. Müşteriye para ödendi."
				};
				_context.Add(customerProcess);
				_context.SaveChanges();
			}
			else if(NextApprover!=null)
			{
				var customerProcess = new CustomerProcessViewModel
				{
					Name = request.Name,
					Price = request.Price,
					EmployeeName = "Burcu Meşe - Gişe Memuru",
					Description = "Para çekme işlemi başarısız oldu. Müşteri, müdür yardımcısına yönlendirildi."
				};
				_context.Add(customerProcess);
				_context.SaveChanges();
				NextApprover.Process(request); //request'ten gelen isteği ata.
			}
		}
	}
}
