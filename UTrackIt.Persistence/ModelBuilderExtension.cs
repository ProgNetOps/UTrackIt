using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTrackIt.Domain;

namespace UTrackIt.Persistence
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var regions = new List<Region>()
            {
                new Region
                {
                    Id = 1,
                    RegionName = "Abuja"
                },
               new Region
               {
                   Id = 2,
                   RegionName = "Benin"
               },
               new Region
               {
                   Id = 3,
                   RegionName = "Enugu"
               },
               new Region
               {
                   Id = 4,
                   RegionName = "Ibadan"
               },

               new Region
               {
                   Id = 5,
                   RegionName = "Lagos"
               },
               new Region
               {
                   Id = 6,
                   RegionName = "PHC"
               }
            };
            var states = new List<State>()
            {
                new State
                {
                    Id = 1,
                    StateName = "Abia",
                    RegionId = 3
                },

               new State
               {
                   Id = 2,
                   StateName = "Abuja",
                   RegionId = 1
               },

               new State
               {
                   Id = 3,
                   StateName = "Adamawa",
                   RegionId = 1
               },
               new State
               {
                   Id = 4,
                   StateName = "Akwa Ibom",
                   RegionId = 6
               },
               new State
               {
                   Id = 5,
                   StateName = "Anambra",
                   RegionId = 3
               },

               new State
               {
                   Id = 6,
                   StateName = "Bauchi",
                   RegionId = 1
               },
               new State
               {
                   Id = 7,
                   StateName = "Bayelsa",
                   RegionId = 6
               },
               new State
               {
                   Id = 8,
                   StateName = "Benue",
                   RegionId = 1
               },

               new State
               {
                   Id = 9,
                   StateName = "Borno",
                   RegionId = 1
               },

               new State
               {
                   Id = 10,
                   StateName = "Cross River",
                   RegionId = 6
               },
               new State
               {
                   Id = 11,
                   StateName = "Delta",
                   RegionId = 2
               },
               new State
               {
                   Id = 12,
                   StateName = "Ebonyi",
                   RegionId = 3
               },
               new State
               {
                   Id = 13,
                   StateName = "Edo",
                   RegionId = 2
               },
               new State
               {
                   Id = 14,
                   StateName = "Ekiti",
                   RegionId = 4
               },
               new State
               {
                   Id = 15,
                   StateName = "Enugu",
                   RegionId = 3
               },
               new State
               {
                   Id = 16,
                   StateName = "Gombe",
                   RegionId = 1
               },
               new State
               {
                   Id = 17,
                   StateName = "Imo",
                   RegionId = 6
               },
               new State
               {
                   Id = 18,
                   StateName = "Jigawa",
                   RegionId = 1
               },
               new State
               {
                   Id = 19,
                   StateName = "Kaduna",
                   RegionId = 1
               },
               new State
               {
                   Id = 20,
                   StateName = "Kano",
                   RegionId = 1
               },
               new State
               {
                   Id = 21,
                   StateName = "Katsina",
                   RegionId = 1
               },
               new State
               {
                   Id = 22,
                   StateName = "Kebbi",
                   RegionId = 1
               },
               new State
               {
                   Id = 23,
                   StateName = "Kogi",
                   RegionId = 1
               },
               new State
               {
                   Id = 24,
                   StateName = "Kwara",
                   RegionId = 4
               },
               new State
               {
                   Id = 25,
                   StateName = "Lagos",
                   RegionId = 5
               },
               new State
               {
                   Id = 26,
                   StateName = "Nasarawa",
                   RegionId = 1
               },
               new State
               {
                   Id = 27,
                   StateName = "Niger",
                   RegionId = 1
               },
               new State
               {
                   Id = 28,
                   StateName = "Ogun",
                   RegionId = 5
               },
               new State
               {
                   Id = 29,
                   StateName = "Ondo",
                   RegionId = 4
               },
               new State
               {
                   Id = 30,
                   StateName = "Osun",
                   RegionId = 4
               },
               new State
               {
                   Id = 31,
                   StateName = "Oyo",
                   RegionId = 4
               },
               new State
               {
                   Id = 32,
                   StateName = "Plateau",
                   RegionId = 1
               },
               new State
               {
                   Id = 33,
                   StateName = "Rivers",
                   RegionId = 6
               },
               new State
               {
                   Id = 34,
                   StateName = "Sokoto",
                   RegionId = 1
               },
               new State
               {
                   Id = 35,
                   StateName = "Taraba",
                   RegionId = 1
               },
               new State
               {
                   Id = 36,
                   StateName = "Yobe",
                   RegionId = 1
               },
               new State
               {
                   Id = 37,
                   StateName = "Zamfara",
                   RegionId = 1
               }
            };
            var linkStatuses = new List<LinkStatus>()
            {
                new LinkStatus
                {
                    Id = Guid.Parse("7e2380db-83a4-48be-b936-6006559c698d"),
                    Name = "Up"
                },
                new LinkStatus
                {
                    Id = Guid.Parse("c7e0e079-8776-4004-879b-6a508d8d56ce"),
                    Name = "Degraded"
                },
                new LinkStatus
                {
                    Id = Guid.Parse("e2795fec-88e7-47d6-bd7a-85ff23a62b45"),
                    Name = "Fluctuating"
                },
                new LinkStatus
                {
                    Id = Guid.Parse("8811346b-dc40-449b-b576-1215630c71b8"),
                    Name = "Slow"
                },
                new LinkStatus
                {
                    Id = Guid.Parse("a4e7183c-2d70-443c-a5b9-f51205cd0577"),
                    Name = "Down"
                }
            };
            var clientCategories = new List<ClientCategory>()
            {
                new ClientCategory
                {
                    Id = Guid.Parse("680d386a-464a-47a6-8dd7-795cdfaa78eb"),
                    Name = "Bank"
                },
                new ClientCategory
                {
                    Id = Guid.Parse("693dd440-3afa-46fb-8048-fb5aa79a6772"),
                    Name = "Others"
                }
            };
            var circuitStates = new List<CircuitState>()
            {
                new CircuitState
                {
                    Id = Guid.Parse("20c3f538-ceb4-4018-940b-139ee845b6aa"),
                    Name = "Active"
                },
                new CircuitState
                {
                    Id = Guid.Parse("833f5d1d-8116-40e4-a424-39befec3d65d"),
                    Name = "Suspended"
                },
                new CircuitState
                {
                    Id = Guid.Parse("3e02853a-454e-421c-9fd7-02ebcaae7f2e"),
                    Name = "Terminated"
                }
            };
            var genders = new List<Gender>()
            {
                new Gender
                {
                    Id = Guid.Parse("82327176-ce6a-441f-a760-2eed95727a77"),
                    Name = "Male"
                },
                new Gender
                {
                    Id = Guid.Parse("b0ca7018-c82a-46c1-9763-1d002cc91f93"),
                    Name = "Female"
                }
            };
            var services = new List<Service>()
            {
                new Service
                {
                    Id = Guid.Parse("51501511-9374-49cd-94db-bb4917a1b33c"),
                    Name = "APN"
                },
                new Service
                {
                    Id = Guid.Parse("2381b08a-0493-415e-91e7-1c68c6ab0114"),
                    Name = "Colocation"
                },
                new Service
                {
                    Id = Guid.Parse("74da66c0-3693-4682-af75-1aef60f08786"),
                    Name = "Internet"
                },
                new Service
                {
                    Id = Guid.Parse("38d7cdc6-0e89-48f2-90a3-767fe9906c5a"),
                    Name = "IPLC"
                },
                new Service
                {
                    Id = Guid.Parse("0748a932-5cf2-46fe-b2a5-153e7ca43061"),
                    Name = "iWAN"
                },
                new Service
                {
                    Id = Guid.Parse("841d0a15-97fb-4a59-95c0-25e7d521bd34"),
                    Name = "Leased Line"
                },
                new Service
                {
                    Id = Guid.Parse("03dc3ab0-1e94-4284-9064-fda8a97b889b"),
                    Name = "PRI"
                },
                new Service
                {
                    Id = Guid.Parse("5c6e171b-dcc3-4680-b146-9037da574d00"),
                    Name = "SIP"
                },
                new Service
                {
                    Id = Guid.Parse("3e382e45-4a86-40b1-b788-637e07727f32"),
                    Name = "FTTH"
                },
                new Service
                {
                    Id = Guid.Parse("18d8e1d1-e868-4f48-b914-67535136cf67"),
                    Name = "Others"
                },
            };

            //Add Seed Data
            modelBuilder.Entity<Region>().HasData(regions);
            modelBuilder.Entity<State>().HasData(states);
            modelBuilder.Entity<LinkStatus>().HasData(linkStatuses);
            modelBuilder.Entity<ClientCategory>().HasData(clientCategories);
            modelBuilder.Entity<CircuitState>().HasData(circuitStates);
            modelBuilder.Entity<Gender>().HasData(genders);
            modelBuilder.Entity<Service>().HasData(services);
        }
    }
}
