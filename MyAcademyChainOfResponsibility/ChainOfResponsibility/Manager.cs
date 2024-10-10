﻿using MyAcademyChainOfResponsibility.DataAccess.Context;
using MyAcademyChainOfResponsibility.Models;

namespace MyAcademyChainOfResponsibility.ChainOfResponsibility
{
	public class Manager : Employee
	{
		private readonly CoFContext _context;
		public Manager(CoFContext context)
		{
			_context = context;
		}

		public override void Process(CustomerProcessViewModel request)
		{
			if (request.Price <= 250000)
			{
				var customerProcess = new CustomerProcessViewModel
				{
					Name = request.Name,
					Price = request.Price,
					EmployeeName = "Gamze Şen - Şube Müdürü",
					Description = "Para çekme işlemi başarıyla gerçekleşti. Müşteriye para ödendi."
				};
				_context.Add(customerProcess);
				_context.SaveChanges();
			}
			else if (NextApprover != null) //Bir sonraki çalışan değeri null'dan farklıysa
			{
				var customerProcess = new CustomerProcessViewModel
				{
					Name = request.Name,
					Price = request.Price,
					EmployeeName = "Gamze Şen - Şube Müdürü",
					Description = "Para çekme işlemi başarısız oldu. Müşteri, bölge müdürüne yönlendirildi."
				};
				_context.Add(customerProcess);
				_context.SaveChanges();
				NextApprover.Process(request); //request'ten gelen isteği ata.
			}
		}
	}
}