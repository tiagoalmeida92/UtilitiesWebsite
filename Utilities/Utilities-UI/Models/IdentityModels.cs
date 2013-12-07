using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Utilities_UI.Migrations;

namespace Utilities_UI.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
            
        }

        public System.Data.Entity.DbSet<ToDo> Assignments { get; set; }

        public System.Data.Entity.DbSet<Utilities_UI.Models.CopyPaste> Pastes { get; set; }

    }
}