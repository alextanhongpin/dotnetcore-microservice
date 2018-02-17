using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Company.TeamService.Controllers;
using Company.TeamService.Models;
using Company.TeamService.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace Company.TeamService.Tests
{
    public class TeamsControllerTest
    {
        private readonly TeamsController _teamsController;

        public TeamsControllerTest() 
        {
            _teamsController = new TeamsController(new MemoryTeamRepository());
        }

        [Fact]
        public async void QueryTeamListReturnsCorrectTeam()
        {
            var newTeamsRaw = (IEnumerable<Team>)(_teamsController.GetAllTeams() as ObjectResult).Value;
            List<Team> newTeams = new List<Team>(newTeamsRaw);
            Assert.Equal(0, newTeams.Count);
        }
    }
}
