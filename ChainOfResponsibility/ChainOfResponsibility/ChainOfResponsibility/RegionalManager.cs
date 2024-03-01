using ChainOfResponsibility.DAL;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.ChainOfResponsibility
{
    public class RegionalManager : Employee
    {
       
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new();
            if (req.Amount <= 400000)
            {
                CustomerProcess customerProcess = new();
                customerProcess.Amount = req.Amount;
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Bölge Müdürü - Zeynep Yılmaz";
                customerProcess.Description = "Para Çekme İşlemi Onaylandı, Müşteriye Talep Ettiği Tutar Ödendi";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else 
            {
                CustomerProcess customerProcess = new();
                customerProcess.Amount = req.Amount;
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Bölge Müdürü - Zeynep Yılmaz";
                customerProcess.Description = "Para Çekme Tutarı Bölge Müdürünün Günlük Ödeyebileceği Limiti Aştığı İçin İşlem Gerçekleştirilemedi," +
                    "Müşterinin Günlük Maksimum Çekebileceği Tutar 400.000 ₺ olduğu için birden fazla gün şubeye gelmesi gerekecektir.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
        }
    }
}
