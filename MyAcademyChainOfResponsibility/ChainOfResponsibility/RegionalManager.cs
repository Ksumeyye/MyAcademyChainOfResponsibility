using MyAcademyChainOfResponsibility.DataAccess.Context;
using MyAcademyChainOfResponsibility.DataAccess.Entities;
using MyAcademyChainOfResponsibility.Models;

namespace MyAcademyChainOfResponsibility.ChainOfResponsibility
{
	public class RegionalManager : Employee
	{
		private readonly CoFContext _context;
			public RegionalManager(CoFContext context)
			{
				_context = context;
			}
			public override void Process(CustomerProcessViewModel request)
			{
				if (request.Price <= 500000)
				{
					var customerProcess = new CustomerProcess
					{
						Name = request.Name,
						Price = request.Price,
						EmployeeName = "Sümeyye Kaya - Bölge Müdürü",
						Description = "Para çekme işlemi başarıyla gerçekleşti. Müşteriye para ödendi."
					};
					_context.Add(customerProcess);
					_context.SaveChanges();
				}
				else
				{
					var customerProcess = new CustomerProcess
					{
						Name = request.Name,
						Price = request.Price,
						EmployeeName = "Sümeyye Kaya - Bölge Müdürü",
						Description = "Para çekme işlemi başarısız oldu. Müşteriye ödenecek para limiti aşıldı."
					};

					_context.Add(customerProcess);
					_context.SaveChanges();
				}
			}
		}
	}
