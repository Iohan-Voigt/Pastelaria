using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastelaria.ORM.Migrations
{
    [DbContext(typeof(PastelariaDBContext))]
    partial class PastelariaDBContextModel : ModelSnapshot
    {
        protected override void BuildModel([NotNullAttribute] ModelBuilder modelBuilder)
        {
            throw new NotImplementedException();
        }
    }
}
