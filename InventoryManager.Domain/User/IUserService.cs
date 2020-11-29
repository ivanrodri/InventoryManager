using System;

namespace InventoryManager.Domain.User
{
    public interface IUserService
    {
        bool ValidateCredentials(String username, String password);
    }
}
