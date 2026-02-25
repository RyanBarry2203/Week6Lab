using Week6Lab;



namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamData db = new TeamData();

            using (db)
            {
                Team t1 = new Team() {TeamID = 1, TeamName = "Warriors", Location = "San Francisco",  };
                Player p1 = new Player() {PlayerID = 1, Name = "Stephen", Position = "Forward", TeamID = 1, Team = t1};
                Player p2 = new Player() { PlayerID = 1, Name = "Klay", Position = "Guard", TeamID = 1, Team = t1 };

                Team t2 = new Team() { TeamID = 2, TeamName = "Lakers", Location = "Los Angeles" };
                Player p3 = new Player() { PlayerID = 1, Name = "LeBron", Position = "Forward", TeamID = 2, Team = t2 };
                Player p4 = new Player() { PlayerID = 1, Name = "Anthony", Position = "Forward", TeamID = 2, Team = t2 };

                db.Teams.Add(t1);
                db.Teams.Add(t2);

                Console.WriteLine("Added teams to DB");

                db.Players.Add(p1);
                db.Players.Add(p2);
                db.Players.Add(p3);
                db.Players.Add(p4);

                Console.WriteLine("Added Players to DB");

                db.SaveChanges();

                Console.WriteLine("Saved to DB");

            }
        }
    }
}
