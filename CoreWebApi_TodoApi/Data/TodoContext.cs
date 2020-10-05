using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebApi_TodoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreWebApi_TodoApi.Data
{
    public class TodoItemContext : DbContext
    {
        public TodoItemContext(DbContextOptions<TodoItemContext> options) : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}