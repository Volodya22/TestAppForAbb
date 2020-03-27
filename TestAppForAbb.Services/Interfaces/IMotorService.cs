using System.Collections.Generic;
using TestAppForAbb.Core.Enum;
using TestAppForAbb.Services.ViewModel;

namespace TestAppForAbb.Services.Interfaces
{
    public interface IMotorService
    {
        List<MotorViewModel> Select();

        int Add(MotorViewModel motor);

        void Update(MotorViewModel motor);

        void Delete(int motorId);
    }
}
