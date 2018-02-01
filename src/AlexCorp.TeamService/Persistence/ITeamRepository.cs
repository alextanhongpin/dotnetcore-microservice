using System.Collections.Generic;
using AlexCorp.TeamService.Models;

namespace AlexCorp.TeamService.Persistence
{
  public interface ITeamRepository
  {
    IEnumerable<Team> GetTeams();
    void AddTeam(Team team);
  }
}