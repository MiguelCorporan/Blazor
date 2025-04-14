using Microsoft.EntityFrameworkCore;
using taskUser.DBModels;
using taskUser.Models;

namespace taskUser.PanelServices
{
    public class AdminPanelServices
    {
        private readonly TareasAppContext _context;

        public AdminPanelServices(TareasAppContext context) { _context = context; }

        public async Task<ResponseModel> Register(RegistrationModel registrationModel)
        {


            Console.WriteLine($"Email recibido: {registrationModel.Email}");
            var existingAdmin = await _context.AdminInfos.FirstOrDefaultAsync(x => x.Email == registrationModel.Email);

            if (existingAdmin != null) 
            {
                return new ResponseModel
                { 
                    Success = false, Message = "An erro ocurred! try again"
                };
            };

           var dbAdminInfo = new AdminInfo
            {
            Name = registrationModel.Name,
            Email = registrationModel.Email,
            Password = registrationModel.Password
            };

            //await _context.AdminInfos.AddAsync(dbAdminInfo);
            await _context.AdminInfos.AddAsync(dbAdminInfo);

            await _context.SaveChangesAsync();

            return new ResponseModel { Success = true, Message = "Resgistration succesful." };
        }


        public async Task<ResponseModel> Login(LoginModel loginModel)
        {
            var user = await _context.AdminInfos.FirstOrDefaultAsync(x => x.Email == loginModel.EmailId);
            if (user == null)
            {
                return new ResponseModel
                {
                    Success = false,
                    Message = "Email not found"
                };
            }

            if (user.Password != loginModel.Password)
            {
                return new ResponseModel
                {
                    Success = false,
                    Message = "Password is incorrect"
                };
            }

            return new ResponseModel
            {
                Success = true,
                Message = Convert.ToString(user.Id) + "|" + user.Name + "|" + user.Email
            };
        }


    }
}
