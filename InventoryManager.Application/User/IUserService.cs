using System;

namespace InventoryManager.Application.User
{
    public interface IUserService
    {
        bool ValidateCredentials(String username, String password);
    }
}
