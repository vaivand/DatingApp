using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

// A service solely responsible for the creation of JWT tokens
// It wont issue the tokens
// That will be the job of our account controller
// All its gonna do is receive an app user and create a token for that user
// and return it to the account controller

namespace API.Interfaces

{
    // The sole reason this is created is that it is better for testing
    public interface ITokenService
    {

        string CreateToken(AppUser user);
        
    }
}
