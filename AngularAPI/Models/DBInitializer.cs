using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularAPI.Models
{
    public class DBInitializer
    {
        public static void Initialize(DataContext context)
        {
            context.Database.EnsureCreated();

            if (context.Gebruikers.Any())
            {
                return;
            }
            context.Gebruikers.AddRange(
                new Gebruiker { Email = "Liam.mentens@hotmail.com", Wachtwoord = "123", Gebruikersnaam = "Liam"},
                new Gebruiker { Email = "HideoKojima@kojimaproductions.com", Wachtwoord = "hideo", Gebruikersnaam = "Kojima" },
                new Gebruiker { Email = "Miyazaki@DarkSouls.com", Wachtwoord = "miyazaki", Gebruikersnaam = "Miyazaki" },
                new Gebruiker { Email = "Pewds@Diepie.com", Wachtwoord = "barrels", Gebruikersnaam = "Pewdiepie" },
                new Gebruiker { Email = "Jack@scepticeye.com", Wachtwoord = "1234", Gebruikersnaam = "Jackscepticeye" }

            );

            context.Lijsten.AddRange(
                new Lijst
                {
                    Naam = "Games of 2016",
                    GebruikerID= 3,
                    Beschrijving = "Best games of 2016",
                    StartDatum = new DateTime(2016, 1, 1), EindDatum= new DateTime(2016,12,31)
                },
                new Lijst
                {
                    Naam = "Games of 2017",
                    GebruikerID = 2,
                    Beschrijving = "Best games of 2017",
                    StartDatum = new DateTime(2017, 1, 1), EindDatum= new DateTime(2017,12,31)
                },
                new Lijst
                {
                    Naam = "Games of 2018",
                    GebruikerID = 4,
                    Beschrijving = "Best games of 2018",
                    StartDatum = new DateTime(2018, 1, 1), EindDatum= new DateTime(2018,12,31)
                }, 
                new Lijst
                {
                    Naam = "Games of 2019",
                    GebruikerID = 1,
                    Beschrijving = "Best games of 2019",
                    StartDatum = new DateTime(2019, 1, 1), EindDatum= new DateTime(2019,12,31)
                },
                  new Lijst
                {
                    Naam = "Games of 2020",
                    GebruikerID = 5,
                    Beschrijving = "Best games of 2020",
                    StartDatum = new DateTime(2020, 1, 1), EindDatum= new DateTime(2020,12,31)
                }
               
            );
            context.SaveChanges();

            //context.LijstGebruiker.AddRange(
            //    new LijstGebruiker { LijstID = 1, GebruikerID = 1 },
            //    new LijstGebruiker { LijstID = 2, GebruikerID = 2 },
            //    new LijstGebruiker { LijstID = 3, GebruikerID = 3 },
            //    new LijstGebruiker { LijstID = 4, GebruikerID = 4 },
            //    new LijstGebruiker { LijstID = 5, GebruikerID = 5 }
            //    );
            //context.SaveChanges();

            context.Items.AddRange(
                new Item { LijstID = 1, Naam = "Overwatch", Beschrijving = "Competitive FPS", Foto = "" },
                new Item { LijstID = 1, Naam = "Dark Souls III", Beschrijving = "Dark Souls continues to push the boundaries with the latest, ambitious chapter in the critically-acclaimed and genre-defining series. Prepare yourself and Embrace The Darkness!", Foto = "" },
                new Item { LijstID = 1, Naam = "Stardew Valley", Beschrijving = "Stardew Valley is an RPG-style farming game.", Foto = "" },
                new Item { LijstID = 1, Naam = "Sid Meier's Civilization VI", Beschrijving = "Civilization VI offers new ways to interact with your world, expand your empire across the map, advance your culture, and compete against history’s greatest leaders to build a civilization that will stand the test of time.", Foto = "" },

                new Item { LijstID = 2, Naam = "The Legend of Zelda: Breath of the Wild", Beschrijving = "Breath of the Wild is part of the Legend of Zelda franchise and is set at the end of the series' timeline; the player controls Link, who awakens from a hundred-year slumber to defeat Calamity Ganon before it can destroy the kingdom of Hyrule. ", Foto = "" },
                new Item { LijstID = 2, Naam = "Super Mario Odyssey", Beschrijving = " An entry in the Super Mario series, it follows Mario and Cappy, a sentient hat that allows Mario to control other characters and objects, as they journey across various worlds to save Princess Peach from his nemesis Bowser, who plans to forcibly marry her. In contrast to the linear gameplay of prior entries, the game returns to the primarily open-ended, 3D platform gameplay featured in Super Mario 64 and Super Mario Sunshine.", Foto = "" },
                new Item { LijstID = 2, Naam = "Horizon Zero Dawn", Beschrijving = "The plot follows Aloy, a hunter in a world overrun by machines, who sets out to uncover her past. ", Foto = "" },
                new Item { LijstID = 2, Naam = "Persona 5", Beschrijving = "Persona 5 takes place in modern-day Tokyo and follows a high school student known by the pseudonym Joker who transfers to a new school after being falsely accused of assault and put on probation.", Foto = "" },

                new Item { LijstID = 3, Naam = "Red Dead Redemption 2", Beschrijving = "RDR2 is the epic tale of outlaw Arthur Morgan and the infamous Van der Linde gang, on the run across America at the dawn of the modern age.", Foto = "" },
                new Item { LijstID = 3, Naam = "God of War", Beschrijving = "Following the death of Kratos' second wife and Atreus' mother, they journey to fulfill her request that her ashes be spread at the highest peak of the nine realms. Kratos keeps his troubled past a secret from Atreus, who is unaware of his divine nature. Along their journey, they encounter monsters and gods of the Norse world. ", Foto = "" },
                new Item { LijstID = 3, Naam = "Super Smash Bros. Ultimate", Beschrijving = " The game follows the series' traditional style of gameplay: controlling one of the various characters, players must use differing attacks to weaken their opponents and knock them out of an arena. It features a wide variety of game modes, including a campaign for single-player and multiplayer versus modes. ", Foto = "" },
                new Item { LijstID = 3, Naam = "Dead Cells", Beschrijving = "Dead Cells is a rogue-lite, metroidvania inspired, action-platformer.", Foto = "" },

                new Item { LijstID = 4, Naam = "Sekiro: Shadows Die Twice", Beschrijving = "The game follows a shinobi known as Wolf as he attempts to take revenge on a samurai clan who attacked him and kidnapped his lord.", Foto = "" },
                new Item { LijstID = 4, Naam = "Resident Evil 2", Beschrijving = "The player controls Leon S. Kennedy and Claire Redfield, who must escape Raccoon City after its citizens are transformed into zombies by a biological weapon two months after the events of the original Resident Evil.", Foto = "" },
                new Item { LijstID = 4, Naam = "Apex Legends", Beschrijving = "In Apex Legends, up to 20 three-person squads land on an island and search for weapons and supplies before attempting to defeat all other players in combat. The available play area on the island shrinks over time, forcing players to keep moving or else find themselves outside the play area which can be fatal.", Foto = "" },
                new Item { LijstID = 4, Naam = "Slay the Spire", Beschrijving = "We fused card games and roguelikes together to make the best single player deckbuilder we could. Craft a unique deck, encounter bizarre creatures, discover relics of immense power, and Slay the Spire!", Foto = "" },

                new Item { LijstID = 5, Naam = "The Last of Us Part II", Beschrijving = "Set five years after The Last of Us (2013), players control 19-year-old Ellie who sets out for revenge and becomes involved in a conflict between a militia and a cult in a post-apocalyptic United States.", Foto = "" },
                new Item { LijstID = 5, Naam = "Half-Life: Alyx", Beschrijving = "Half-Life: Alyx is Valve’s VR return to the Half-Life series. It’s the story of an impossible fight against a vicious alien race known as the Combine, set between the events of Half-Life and Half-Life 2. ", Foto = "" },
                new Item { LijstID = 5, Naam = "Animal Corssing: New Horizons", Beschrijving = "In New Horizons, the player assumes the role of a customizable character who moves to a deserted island after purchasing a package from Tom Nook, a tanuki character who has appeared in every entry in the Animal Crossing series. Taking place in real-time, the player can explore the island in a nonlinear fashion, gathering and crafting items, catching insects and fish, and developing the island into a community of anthropomorphic animals. ", Foto = "" },
                new Item { LijstID = 5, Naam = "Doom Eternal", Beschrijving = "Hell’s armies have invaded Earth. Become the Slayer in an epic single-player campaign to conquer demons across dimensions and stop the final destruction of humanity. The only thing they fear... is you.", Foto = "" }
               );
            context.SaveChanges();

            context.Stemmen.AddRange(
             new Stem { ItemID = 1, GebruikerID = 1 },
             new Stem { ItemID = 3, GebruikerID = 1 },
             new Stem { ItemID = 5, GebruikerID = 1 },
             new Stem { ItemID = 4, GebruikerID = 2 },
             new Stem { ItemID = 2, GebruikerID = 2 },
             new Stem { ItemID = 3, GebruikerID = 2 },
             new Stem { ItemID = 10, GebruikerID = 3 },
             new Stem { ItemID = 8, GebruikerID = 3 },
             new Stem { ItemID = 9, GebruikerID = 3 },
             new Stem { ItemID = 15, GebruikerID = 4 },
             new Stem { ItemID = 16, GebruikerID = 4 },
             new Stem { ItemID = 19, GebruikerID = 4 }
               );
            context.SaveChanges();
        }
    }
}
