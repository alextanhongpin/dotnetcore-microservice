using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Xunit;

using AlexCorp.TeamService.Models;
using AlexCorp.TeamService.Controllers;
using AlexCorp.TeamService.Persistence;

using Microsoft.AspNetCore.Mvc;

namespace AlexCorp.TeamService
{
    public class TeamControllerTest
    {
      // static ICollection<Team> teams = new List<Team>(){ new Team("one"), new Team("two") };
      TeamsController controller = new TeamsController(new MemoryTeamRepository());

      [Fact]
      public async void QueryTeamListReturnsCorrectTeam()
      {
        // List<Team> teams = new List<Team>(controller.GetAllTeams());
        var teamsRaw = (IEnumerable<Team>)(await controller.GetAllTeams() as ObjectResult).Value;
        // var teamsRaw = await controller.GetAllTeams();
        List<Team> newTeams = new List<Team>(teamsRaw);
        Assert.NotNull(newTeams);
        // Assert.Equal(2, newTeams.Count);
      }

      // [Fact]
      // public async void CreateTeamAddsTeamToList()
      // {
      //   TeamsController controller = new TeamsController();
      //   var teams = (IEnumerable<Team>)(await controller.GetAllTeams() as ObjectResult).Value;
      //   List<Team> original = new List<Team>(teams);

      //   Team t = new Team("sample");
      //   var result = await controller.CreateTeam(t);

      //   var newTeamsRaw = (IEnumerable<Team>)(await controller.GetAllTeams() as ObjectResult).Value;

      //   List<Team> newTeams = new List<Team>(newTeamsRaw);
      //   Assert.Equal(newTeams.Count, original.Count + 1);

      //   var sampleTeam = newTeams.FirstOrDefault(target => target.Name == "sample");
      //   Assert.NotNull(sampleTeam);
      // } 
    }
}