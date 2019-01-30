﻿using Archysoft.D1.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Archysoft.D1.Data
{
    public class DatabaseInitializator : IDatabaseInitializator
    {
        private readonly DataContext _dataContext;
        private readonly UserManager<User> _userManager;

        public DatabaseInitializator(DataContext dataContext, UserManager<User> userManager)
        {
            _dataContext = dataContext;
            _userManager = userManager;
        }

        public void Initialize()
        {
            _dataContext.Database.Migrate();
            if (!_dataContext.Users.Any())
            {
                var user = new User
                {

                };
            }

        }
    }
}
