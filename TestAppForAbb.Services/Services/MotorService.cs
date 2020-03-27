using TestAppForAbb.Core.Models;
using TestAppForAbb.DataLayer.Repository;
using TestAppForAbb.Services.Interfaces;

namespace TestAppForAbb.Services.Services
{
    public class MotorService : AbstractEntityService<Motor>, IMotorService
    {
        public MotorService(IRepository context) : base(context)
        {

        }
    }
}
