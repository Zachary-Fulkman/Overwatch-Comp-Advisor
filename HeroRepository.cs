namespace Overwatch_2_Suggestions
{
    public static class HeroRepository
    {
        public static List<Hero> GetHeroes()
        {
            return new List<Hero>
            {
                new Hero 
                {
                    Name = "Reinhardt",
                    Role = Role.Tank,
                    Counters = new List<string> { "Orisa", "Winston", "Doomfist", "Ramattra", "Hazard", "Reaper", "Bastion", "Pharah", "Ana", "Mei", "Zenyatta", "Lucio" },
                    Synergies = new List<string> { "Sojourn", "Soldier: 76", "Echo", "Bastion", "Ana", "Lifeweaver", "Kiriko", "Lucio", "Juno" },
                    PlaystyleTag = PlaystyleTag.Brawl,
                    MapPreference = new List<string> { "Kings_Row", "Dorado", "Numbani", "New_Queen_Street", "Circuit_Royal", "Havana" }
                },
                new Hero
                {
                    Name = "D.Va",
                    Role = Role.Tank,
                    Counters = new List<string> { "Zarya", "Sigma", "Ramattra", "Mei", "Symettra", "Reaper", "Cassidy", "Sojourn", "Sombra", "Echo", "Ana", "Zenyatta", "Kiriko" },
                    Synergies = new List<string> { "Tracer", "Genji", "Sombra", "Echo", "Sojourn", "Ana", "Lifeweaver", "Kiriko", "Zenyatta", "Mercy" },
                    PlaystyleTag = PlaystyleTag.Dive,
                    MapPreference = new List<string> { "New_Queen_Street", "Oasis", "Lijiang_Tower", "Eichenwalde", "Circuit_Royal", "Colosseo", "Kings_Row" }
                },
                new Hero
                {
                    Name = "Doomfist",
                    Role = Role.Tank,
                    Counters = new List<string> { "Roadhog", "Orisa", "Sigma", "Pharah", "Echo", "Mei", "Sombra", "Symmetra", "Reaper", "Ana" },
                    Synergies = new List<string> { "Genji", "Tracer", "Venture", "Echo", "Reaper", "Lifeweaver", "Kiriko" },
                    PlaystyleTag = PlaystyleTag.Dive,
                    MapPreference = new List<string> { "New_Queen_Street", "Lijiang_Tower", "Oasis", "Circuit_Royal", "Eichenwalde" }
                },
                 new Hero
                {
                    Name = "Hazard",
                    Role = Role.Tank,
                    Counters = new List<string> { "Roadhog", "Mauga", "Orisa", "Bastion", "Symmetra", "Sombra", "Reaper", "Sojourne", "Ana", "Kiriko", "Zenyatta" },
                    Synergies = new List<string> { "Tracer", "Sombra", "Venture", "Echo", "Hanzo", "Ashe", "Genji", "Kiriko", "Lifeweaver", "Lucio" },
                    PlaystyleTag = PlaystyleTag.Dive,
                    MapPreference = new List<string> { "New_Queen_Street", "Lijiang_Tower", "Oasis", "Circuit_Royal", "Eichenwalde" }
                },
                 new Hero
                 {
                     Name = "Junker_Queen",
                     Role = Role.Tank,
                     Counters = new List<string> { "Orisa", "Wrecking_Ball", "Zarya", "Cassidy", "Mei", "Reaper", "Sojourn", "Torbjorn", "Freja", "Ana", "Baptiste", "Kiriko" },
                     Synergies = new List<string> { "Sojourn", "Reaper", "Soldier_76", "Junkrat", "Ashe", "Juno", "Lucio", "Kiriko" },
                     PlaystyleTag = PlaystyleTag.Brawl,
                     MapPreference = new List<string> { "New_Queen_Street", "Circuit_Royal", "Colosseo", "Kings_Row", "Dorado", "Numbani" }
                 },
                 new Hero
                 {
                     Name = "Mauga",
                     Role = Role.Tank,
                     Counters = new List<string> { "Sigma", "Reinhardt", "Zarya", "Bastion", "Reaper", "Echo", "Mei", "Ana", "Brigitte", "Lucio", "WidowMaker" },
                     Synergies = new List<string> { "Sojourn", "Soldier_76", "Mei", "Kiriko", "Illari", "Baptiste", "Ana", "Lifeweaver" },
                     PlaystyleTag = PlaystyleTag.Brawl,
                     MapPreference = new List<string> { "New_Queen_Street", "Circuit_Royal", "Colosseo", "Kings_Row", "Dorado", "Numbani" }
                 },
                 new Hero
                 {
                     Name = "Orisa",
                     Role = Role.Tank,
                     Counters = new List<string> { "Zarya", "Mauga", "Bastion", "Symmetra", "Echo", "Hanzo", "Mei", "Reaper", "Cassidy", "Ana", "Zenyatta" },
                     Synergies = new List<string> { "Reaper", "Sojourn", "Junkrat", "Ashe", "Ana", "Kiriko", "Lucio", "Moira" },
                     PlaystyleTag = PlaystyleTag.Brawl,
                     MapPreference = new List<string> { "Junkertown", "Route_66", "Eichenwalde", "Hollywood", "Kings_Row" }
                 },
                 new Hero
                 {
                     Name = "Ramattra",
                     Role = Role.Tank,
                     Counters = new List<string> { "Sigma", "Mauga", "Orisa", "Zarya", "Bastion", "Ashe", "Sombra", "Hanzo", "Ana", "Zenyatta" },
                     Synergies = new List<string> { "Reaper", "Mei", "Ashe", "Freja", "Sojourn", "Juno", "Lucio", "Lifeweaver" },
                     PlaystyleTag = PlaystyleTag.Brawl,
                     MapPreference = new List<string> { "Circuit_Royal", "Colosseo", "Eichenwalde", "Junkertown", "Kings_Row" }
                 },
                 new Hero
                 {
                     Name = "Roadhog",
                     Role = Role.Tank,
                     Counters = new List<string> { "Orisa", "Reinhardt", "Mauga", "Reaper", "Symmetra", "Bastion", "Hanzo", "Pharah", "Ana", "Zenyatta", "Kiriko"},
                     Synergies = new List<string> { "Mei", "Reaper", "Tornjorn", "Tracer", "Echo", "Kiriko", "Illari", "Baptiste" },
                     PlaystyleTag = PlaystyleTag.Hybrid,
                     MapPreference = new List<string> { "Eichenwalde", "Rialto", "Circuit_Royal", "Lijang_Tower", "Oasis", "Ilios", "Paraiso" }
                 },
                 new Hero
                 {
                     Name = "Sigma",
                     Role = Role.Tank,
                     Counters = new List<string> { "Zarya", "Winston", "JunkerQueen", "Echo", "Symmetra", "Sombra", "Mei", "Kiriko", "Brigette", "Baptiste" },
                     Synergies = new List<string> { "Ashe", "Hanzo", "Widowmaker", "Bastion", "Sojourn", "Soldier_76", "Ana", "Illari", "Moira", "Ana" },
                     PlaystyleTag = PlaystyleTag.Poke,
                     MapPreference = new List<string> { "Circuit_Royal", "Dorado", "Havana", "Watchpoint_Gibraltar", "Route_66", "Paraiso" }
                 },
                 new Hero
                 {
                     Name = "Winston",
                     Role = Role.Tank,
                     Counters = new List<string> { "Roadhog", "JunkerQueen", "Mauga", "Bastion", "Reaper", "Torbjorn", "Venture", "Ana", "Moira" },
                     Synergies = new List<string> { "Tracer", "Sombra", "Echo", "Genji", "Venture", "Freja", "Kiriko", "Moira", "Lifeweaver" },
                     PlaystyleTag = PlaystyleTag.Dive,
                     MapPreference = new List<string> { "Watchpoint_Gibraltar", "Circuit_Royal", "Kings_Row", "MidTown", "New_Queen_Street", "Ilios" }
                 },
                 new Hero
                 {
                     Name = "Wrecking_Ball",
                     Role = Role.Tank,
                     Counters = new List<string> { "Roadhog", "Sojourn", "JunkerQueen", "Sigma", "Sombra", "Symettra", "Torbjorn", "Reaper", "Phara", "Echo", "Ana", "Kiriko", "Brigette" },
                     Synergies = new List<string> { "tracer", "Freja", "Venture", "Sojourn", "WidowMaker", "Mei", "Junkrat", "Moira", "Lifeweaver", "Kiriko" },
                     PlaystyleTag = PlaystyleTag.Hybrid,
                     MapPreference = new List<string> { "Havana", "Watchpoint_Gibraltar", "Junkertown", "Colosseo", "Nambani", "New_Queen_Street" }
                 },
                 new Hero
                 {
                     Name = "Zarya",
                     Role = Role.Tank,
                     Counters = new List<string> { "Reinhardt", "Roadhog", "Winston", "Reaper", "Bastion", "Sojourn", "Ashe", "Cassidy", "Mei", "Ana", "Kiriko", "Illari", "Baptiste" },
                     Synergies = new List<string> { "Reaper", "Junkrat", "Tarcer", "Genji", "Venture", "Cassidy", "Ana", "Baptiste", "Kirkiko", "Mercy" },
                     PlaystyleTag = PlaystyleTag.Brawl,
                     MapPreference = new List<string> { "Kings_Row", "Eichenwalde", "Colosseo", "Nepal", "Midtowne" }
                 }
            };
        }
    }
}
