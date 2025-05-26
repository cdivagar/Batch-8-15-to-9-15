using MVVM.Model;
namespace MVVM.ViewModel
{
    public class RegisterViewModel
    {
       public RegisterModel RegModel { get; set; }//MVVM.Model oda projecta referece pani, athuku oru property create panrom.
        public RegisterViewModel()//Intha constuructor ethuku create panromna ,int Name apdingara property ku oru value set pani atha UI la assign panrathuku.
        {
            if(RegModel is null)//Model property class ku oru object create panrom.
            {
                RegModel = new RegisterModel();
            }
            RegModel.Name = "divagar";
            RegModel.Age = 20;
            RegModel.Qualification = "Bsc";
            RegModel.Salary = 25000;
        }
    }
}
