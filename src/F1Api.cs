using System.Net.Http;

namespace Formula1Api
{
    public class F1Api
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://f1api.dev/api";
        public F1Api()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36");
        }

        public async Task<string> GetDrivers()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/drivers");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> SearchDriver(string query, int offset = 0, int limit = 30)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/drivers/search?q={query}&offset={offset}&limit={limit}");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetDriver(string driverId)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/drivers/{driverId}");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetDriversByYear(int year, int offset = 0, int limit = 30)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/{year}/drivers?offset={offset}&limit={limit}");
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetCurrentDrivers()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/current/drivers");
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetTeams()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/teams");
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> SearchTeam(string query, int offset = 0, int limit = 30)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/teams/search?q={query}&offset={offset}&limit={limit}");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetTeam(string teamId)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/{teamId}");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetTeamsByYear(int year, int offset = 0, int limit = 30)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/{year}/teams?offset={offset}&limit={limit}");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetCurrentTeams()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/current/teams");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetSeasons()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/seasons");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetFp1Results(int year, int round)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/{year}/{round}/fp1");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetFp2Results(int year, int round)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/{year}/{round}/fp2");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetFp3Results(int year, int round)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/{year}/{round}/fp3");
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetQualyResults(int year, int round)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/{year}/{round}/qualy");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetRaceResults(int year, int round)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/{year}/{round}/race");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetSprintQualyResults(int year, int round)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/{year}/{round}/sprint/qualy");
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetSprintRaceResults(int year, int round)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/{year}/{round}/sprint/race");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetLastFp1Results()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/last/fp1");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetLastFp2Results()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/last/fp2");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetLastFp3Results()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/last/fp2");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetLastQualyResults()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/last/qualy");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetLastRaceResults()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/last/race");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetLastSprintQualyResults()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/last/sprint/qualy");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetLastSprintRaceResults()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/last/sprint/race");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetStandings(int year)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/{year}/drivers-championship");
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetCurrentStandings()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/current/drivers-championship");
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetConstructorStandings(int year)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/{year}/constructor-championship");
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetCurrentConstructorStandings()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/current/constructor-championship");
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetCircuits()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/circuits");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> SearchCircuit(string query, int offset = 0, int limit = 30)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/circuits/search?q={query}&offset={offset}&limit={limit}");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetCircuit(string circuitId)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/circuits/{circuitId}");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetRace(int year)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/{year}");
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetCurrentRace()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/current");
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetLastRace()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/current/last");
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetNextRace()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/current/next");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
