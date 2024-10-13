using MyAcademyChainOfResponsibility.Models;

namespace MyAcademyChainOfResponsibility.ChainOfResponsibility
{
	public abstract class Employee //abstract sınıflarda methodların içerisi doldurulur. Abstract edilmiş sınıflar miras edilerek kendimize uyarlamış oluruz. İnterface'de doldurulmaz.
	{
		protected Employee NextApprover;
		public void SetNextApprover(Employee supervisor)
		{
			this.NextApprover = supervisor;
		}
		public abstract void Process(CustomerProcessViewModel request); // Process ile view model içerisinden gelen request'i gönderiyoruz. Gönderdiğimiz zaman işlemleri yapıyor.
	}
}
