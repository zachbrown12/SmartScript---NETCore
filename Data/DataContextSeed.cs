using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SmartScript_NETCore.Models;

namespace SmartScript_NETCore.Data
{
    public class DataContextSeed
    {
        [Obsolete]
        public static async Task SeedAsync(DataContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if (!context.Users.Any())
                {
                    var usersData = File.ReadAllText("./Data/SeedData/User.json");

                    var users = JsonSerializer.Deserialize<List<User>>(usersData);

                    context.Database.OpenConnection();

                    foreach (var item in users)
                    {
                        context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Users] ON");
                        context.Users.Add(item);
                    }
                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Users] ON");
                    await context.SaveChangesAsync();
                    context.Database.CloseConnection();

                }
                if (!context.Variants.Any())
                {
                    var variantsData = File.ReadAllText("./Data/SeedData/Variant.json");

                    var variants = JsonSerializer.Deserialize<List<Variant>>(variantsData);


                    context.Database.OpenConnection();

                    foreach (var item in variants)
                    {
                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Variants] ON");
                        context.Variants.Add(item);
                    }
                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Variants] ON");
                    await context.SaveChangesAsync();
                    context.Database.CloseConnection();


                }
                if (!context.Chemicals.Any())
                {
                    var chemicalsData = File.ReadAllText("./Data/SeedData/Chemical.json");

                    var chemicals = JsonSerializer.Deserialize<List<Chemical>>(chemicalsData);

                    context.Database.OpenConnection();

                    foreach (var item in chemicals)
                    {
                        context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Chemicals] ON");
                        context.Chemicals.Add(item);
                    }
                    
                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Chemicals] ON");
                    await context.SaveChangesAsync();
                    context.Database.CloseConnection();

                }
                if (!context.Drugs.Any())
                {
                    var drugsData = File.ReadAllText("./Data/SeedData/Drug.json");

                    var drugs = JsonSerializer.Deserialize<List<Drug>>(drugsData);

                    context.Database.OpenConnection();

                    foreach (var item in drugs)
                    {
  
                      context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Drugs] ON");
                      context.Drugs.Add(item);
                    }
                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Drugs] ON");
                    await context.SaveChangesAsync();
                    context.Database.CloseConnection();

                }
                if (!context.UserVariants.Any())
                {
                    var uservariantsData = File.ReadAllText("./Data/SeedData/UserVariant.json");

                    var uservariants = JsonSerializer.Deserialize<List<UserVariant>>(uservariantsData);

                    context.Database.OpenConnection();

                    foreach (var item in uservariants)
                    {
                        context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UserVariants] ON");
                        context.UserVariants.Add(item);
                    }
                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UserVariants] ON");
                    await context.SaveChangesAsync();
                    context.Database.CloseConnection();

                }
                if (!context.Effects.Any())
                {
                    var effectsData = File.ReadAllText("./Data/SeedData/Effect.json");

                    var effects = JsonSerializer.Deserialize<List<Effect>>(effectsData);

                    context.Database.OpenConnection();

                    foreach (var item in effects)
                    {
                        context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Effects] ON");
                        context.Effects.Add(item);
                    }
                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Effects] ON");

                    await context.SaveChangesAsync();
                    context.Database.CloseConnection();
                }
                if (!context.Ingredients.Any())
                {
                    var ingredientsData = File.ReadAllText("./Data/SeedData/Ingredient.json");

                    var ingredients = JsonSerializer.Deserialize<List<Ingredient>>(ingredientsData);

                    context.Database.OpenConnection();

                    foreach (var item in ingredients)
                    {
                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Ingredients] ON");
                    context.Ingredients.Add(item);
                    }
                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Ingredients] ON");
                    await context.SaveChangesAsync();
                    context.Database.CloseConnection();

                }
                if (!context.Prescriptions.Any())
                {
                    var prescriptionsData = File.ReadAllText("./Data/SeedData/Prescription.json");

                    var prescriptions = JsonSerializer.Deserialize<List<Prescription>>(prescriptionsData);

                    context.Database.OpenConnection();

                    foreach (var item in prescriptions)
                    {
                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Prescriptions] ON");
                    context.Prescriptions.Add(item);
                    }

                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Prescriptions] ON");
                    await context.SaveChangesAsync();
                    context.Database.CloseConnection();

                }
                if (!context.UserRows.Any())
                {
                    var userrowsData = File.ReadAllText("./Data/SeedData/UserRow.json");

                    var userrows = JsonSerializer.Deserialize<List<UserRow>>(userrowsData);

                    context.Database.OpenConnection();

                    foreach (var item in userrows)
                    {
                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UserRows] ON");

                        context.UserRows.Add(item);
                    }
                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UserRows] ON");
                    await context.SaveChangesAsync();
                    context.Database.CloseConnection();

                }


            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<DataContextSeed>();
                logger.LogError(ex.Message);

            }
        }
    }
}