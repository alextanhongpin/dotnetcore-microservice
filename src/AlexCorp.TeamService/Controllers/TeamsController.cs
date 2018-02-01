using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;

using AlexCorp.TeamService.Models;
using AlexCorp.TeamService.Persistence;

namespace AlexCorp.TeamService.Controllers
{
    public class TeamsController: Controller
    {
      ITeamRepository repository;

      public TeamsController(ITeamRepository repo)
      {
        repository = repo;
      }

      [HttpGet]
      // public async virtual Task<IActionResult> GetAllTeams()
      public async virtual Task<IActionResult> GetAllTeams()
      {
        // return Enumerable.Empty<Team>();
        // return new Team[]{ new Team("one"), new Team("two") };
        return this.Ok(repository.GetTeams());
      }
    }
}