using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace KPopStore.Models;

public partial class KPopStoreContext : DbContext
{
    public KPopStoreContext(DbContextOptions<KPopStoreContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
