﻿using CashFlowAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CashFlowAPI.Infrastructure.Context;
public class CashFlowContext : DbContext
{
    public CashFlowContext (DbContextOptions<CashFlowContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Sheet> Sheets { get; set; }
    public DbSet<FinancialEntry> FinancialEntries { get; set; }
    public DbSet<FinancialExpense> FinancialExpenses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CashFlowContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
