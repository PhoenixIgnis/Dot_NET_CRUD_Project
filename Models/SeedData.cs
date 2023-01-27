using Dot_NET_CRUD_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Dot_NET_CRUD_Project.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new DatabaseContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<DatabaseContext>>()))
        {
            // Look for any Buildings, seed (buildings with customers with PartNumbers) if there's no buildings in the database
            if (!context.Buildings.Any())
            {
                context.Buildings.AddRange(

                    //Buildings 1
                    new Buildings { Building = "Planta Central",
                        Customers = new List<Customers>
                        {
                            //Customers 1
                            new Customers { Customer = "Taller Mecánico del Norte", Prefix = "TMDN", 
                                PartNumbers = new List<PartNumbers>{
                                    new PartNumbers { PartNumber = Guid.NewGuid().ToString(), Available = false },
                            } },
                            //Customers 2
                            new Customers { Customer = "Central Eléctrica", Prefix = "CE",
                                PartNumbers = new List<PartNumbers>{
                                    new PartNumbers { PartNumber = Guid.NewGuid().ToString(), Available = true},
                            } },
                        }
                    },

                    //Buildings 2
                    new Buildings { Building = "Cede Norte",
                        Customers = new List<Customers>
                        {
                            //Customers 3
                            new Customers{ Customer = "Transportes del Meridiano", Prefix = "TM",
                                PartNumbers = new List<PartNumbers>{
                                    new PartNumbers { PartNumber = Guid.NewGuid().ToString(), Available = true},
                            } },
                        }
                    },

                    //Buildings 3
                    new Buildings { Building = "Edificio Sur",
                        Customers = new List<Customers>
                        {
                            //Customers 4
                            new Customers  { Customer = "Refacciones ANVIL", Prefix = "RA",
                                PartNumbers = new List<PartNumbers>{
                                    new PartNumbers { PartNumber = Guid.NewGuid().ToString(), Available = true},
                                } },
                        }

                    }
                );

            }
           
            context.SaveChanges();
        }
    }
}
