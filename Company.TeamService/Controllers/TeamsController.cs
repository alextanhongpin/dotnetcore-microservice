using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Company.TeamService.Models;
using Company.TeamService.Persistence;

namespace Company.TeamService.Controllers
{
    public class TeamsController : Controller
    {
        ITeamRepository _repository;

        public TeamsController(ITeamRepository repo)
        {
            _repository = repo;            
        }


        [HttpGet]
        // public IEnumerable<Team> GetAllTeams()
        public IActionResult GetAllTeams()
        {
            // return _repository.GetTeams();
            return this.Ok(_repository.GetTeams());
            // return new Team[] { new Team("one"), new Team("two")};
        //   return Enumerable.Empty<Team>();
        }
    }
}
