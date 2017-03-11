﻿using Microsoft.EntityFrameworkCore;
using ServantApply.Common;
using ServantApply.Common.IManagers;
using ServantApply.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServantApply.Core
{
    public class UserManager : IUserManager
    {
        private readonly ApplicationDbContext context;
        public UserManager(ApplicationDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// 增
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task CreateAsync(User user)
        {
            context.User_users.Add(user);
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// 删
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task DeleteAsync(User user)
        {
            context.User_users.Remove(user);
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// 查
        /// </summary>
        /// <returns></returns>
        public async Task<List<User>> QueryAsync()
        {
            //var takeUser = await context.User_users.TakeWhile(c => c.Id == 1).ToListAsync();
            var userModel = await context.User_users.SingleAsync(c => c.Id == 1);
            var user = context.User_users.Single(b => b.Id == 1);
            var users = await context.User_users.ToListAsync();
            //var Userss = context.User_users.Where(c => c.Name.Contains("ew".Trim())).ToList();    //contains存在问题
            var usersss = context.User_users.FromSql("Select * from user_users where id > 10 limit 0, 10").ToList();
            return usersss;
        }

        /// <summary>
        /// 改
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task UpdateAsync(User user)
        {
            context.User_users.Update(user);
            await context.SaveChangesAsync();
        }
    }
}