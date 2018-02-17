using System.Collections.Generic;
using Company.TeamService.Models;

namespace Company.TeamService.Persistence
{
  public interface ITeamRepository
  {
    IEnumerable<Team> GetTeams();
    void AddTeam(Team team);
  }
}